using System.Windows.Controls;
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

    private void HddsListView_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        ItemSelected.Invoke(this, _db.Hdds.FirstOrDefault(u=> u.Id == _hddList[HddsListView.SelectedIndex].Id)!);
        NavigationService!.Content = null;
    }
}