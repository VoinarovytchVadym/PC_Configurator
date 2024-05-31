using System.Windows.Controls;
using System.Windows.Input;
using PC_Configurator.core;
using PC_Configurator.models.products;

namespace PC_Configurator.views;

public partial class MotherboardSelectionPage : Page
{
    private List<Motherboard> _motherboards;
    private readonly Db _db = Db.GetInstance();
    public MotherboardSelectionPage()
    {
        InitializeComponent();
        if(MainWindow.Cpu == null)
            _motherboards = _db.Motherboards.ToList();
        else
            _motherboards =_db.Motherboards.Where(u => u.Socket == MainWindow.Cpu.Socket).ToList();
        MotherboardListView.ItemsSource = _motherboards;
    }
    public event EventHandler<Motherboard> ItemSelected;
    public event EventHandler DeleteSelection;

    private void MotherboardListView_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        ItemSelected.Invoke(this, _db.Motherboards.FirstOrDefault(u => u.Id == _motherboards[MotherboardListView.SelectedIndex].Id)!);
        NavigationService!.Content = null;
    }

    private void Border_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
        DeleteSelection?.Invoke(this, EventArgs.Empty);

    }
}