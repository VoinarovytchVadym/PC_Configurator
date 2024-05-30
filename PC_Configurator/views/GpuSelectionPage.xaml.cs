using System.Windows.Controls;
using PC_Configurator.core;
using PC_Configurator.models.products;

namespace PC_Configurator.views;

public partial class GpuSelectionPage : Page
{
    private readonly List<Gpu> _gpuList;
    private readonly Db _db = Db.GetInstance();
    public GpuSelectionPage()
    {
        InitializeComponent();
        _gpuList = _db.Gpus.ToList();
        GpusListView.ItemsSource = _gpuList;
    }
    public event EventHandler<Gpu> ItemSelected;

    private void GpusListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        ItemSelected.Invoke(this, _db.Gpus.FirstOrDefault(u => u.Id == _gpuList[GpusListView.SelectedIndex].Id)!);
        NavigationService!.Content = null;
    }
}