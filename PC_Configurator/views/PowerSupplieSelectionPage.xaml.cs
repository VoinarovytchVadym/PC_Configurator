using System.Windows.Controls;
using System.Windows.Input;
using PC_Configurator.core;
using PC_Configurator.models.products;

namespace PC_Configurator.views;

public partial class PowerSupplieSelectionPage : Page
{ private readonly List<PowerSupplie> _powerSupplieList;
    private readonly Db _db = Db.GetInstance();
    
    public PowerSupplieSelectionPage()
    {
        InitializeComponent();
        _powerSupplieList = _db.PowerSupplies.ToList();
        PowerSuppliesListView.ItemsSource = _powerSupplieList;
    }
    public event EventHandler<PowerSupplie> ItemSelected;
    public event EventHandler DeleteSelection;

    private void PowerSuppliesListView_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        ItemSelected.Invoke(this, _db.PowerSupplies.FirstOrDefault(u=> u.Id == _powerSupplieList[PowerSuppliesListView.SelectedIndex].Id)!);
        NavigationService!.Content = null;
    }

    private void Border_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
        DeleteSelection?.Invoke(this, EventArgs.Empty);

    }
}