using System.Windows.Controls;
using PC_Configurator.core;
using PC_Configurator.models.products;

namespace PC_Configurator.views;

public partial class SsdSelectionPage : Page
{
    private readonly List<Ssd> _ssdList;
    private readonly Db _db = Db.GetInstance();
    public SsdSelectionPage()
    {
        InitializeComponent();
        _ssdList = _db.Ssds.ToList();
        SsdsListView.ItemsSource = _ssdList;
    }

    public event EventHandler<Ssd> ItemSelected;
    private void SsdsListView_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        ItemSelected.Invoke(this, _db.Ssds.FirstOrDefault(u=> u.Id == _ssdList[SsdsListView.SelectedIndex].Id)!);
        NavigationService!.Content = null;
    }
}