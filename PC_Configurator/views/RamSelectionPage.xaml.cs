using System.Windows.Controls;
using System.Windows.Input;
using PC_Configurator.core;
using PC_Configurator.models.products;

namespace PC_Configurator.views;

public partial class RamSelectionPage : Page
{
    private readonly List<Ram> _ramList;
    private readonly Db _db = Db.GetInstance();
    public RamSelectionPage()
    {
        InitializeComponent();
        _ramList = _db.Rams.ToList();
        RamsListView.ItemsSource = _ramList;
    }

    public event EventHandler<Ram> ItemSelected = null!;
    public event EventHandler DeleteSelection;

    private void RamsListView_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        ItemSelected.Invoke(this,_db.Rams.FirstOrDefault(u=>u.Id == _ramList[RamsListView.SelectedIndex].Id)!);
        NavigationService!.Content = null;
    }

    private void Border_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
        DeleteSelection?.Invoke(this, EventArgs.Empty);

    }
}