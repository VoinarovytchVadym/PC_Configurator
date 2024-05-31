using System.Windows.Controls;
using System.Windows.Input;
using PC_Configurator.core;
using PC_Configurator.models.products;

namespace PC_Configurator.views;

public partial class HddSelectionPage : Page
{
    private readonly List<Hdd> _hddList;
    private readonly Db _db = Db.GetInstance();
    public HddSelectionPage()
    {
        InitializeComponent();
        _hddList = _db.Hdds.ToList();
        HddsListView.ItemsSource = _hddList;
    }
    public event EventHandler<Hdd> ItemSelected;
    public event EventHandler DeleteSelection;

    private void HddsListView_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        ItemSelected.Invoke(this, _db.Hdds.FirstOrDefault(u=> u.Id == _hddList[HddsListView.SelectedIndex].Id)!);
        NavigationService!.Content = null;
    }

    private void Border_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
        DeleteSelection?.Invoke(this, EventArgs.Empty);

    }
}