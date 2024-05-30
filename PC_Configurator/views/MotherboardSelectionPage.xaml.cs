using System.Windows.Controls;
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
        _motherboards = _db.Motherboards.ToList();
        MotherboardListView.ItemsSource = _motherboards;
    }
    public event EventHandler<Motherboard> ItemSelected;

    private void MotherboardListView_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        ItemSelected.Invoke(this, _db.Motherboards.FirstOrDefault(u => u.Id == _motherboards[MotherboardListView.SelectedIndex].Id)!);
        NavigationService!.Content = null;
    }
}