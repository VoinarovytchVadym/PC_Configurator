using System.Windows;
using System.Windows.Controls;
using PC_Configurator.core;
using PC_Configurator.models.gpus;

namespace PC_Configurator.views;

public partial class GpuSelectionPage : Page
{
    List<Gpu> gpuList;
    public GpuSelectionPage()
    {
        InitializeComponent();
        DB db = DB.GetInstance();
        gpuList = db.Gpus.ToList();
        GpusListView.ItemsSource = gpuList;
    }
    public event EventHandler<Gpu> ItemSelected;

    private void GpusListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        DB db = DB.GetInstance();
        Gpu gpu = db.Gpus.FirstOrDefault(u => u.Id == gpuList[GpusListView.SelectedIndex].Id);
        ItemSelected.Invoke(this, gpu);
        NavigationService.Content = null;
    }
}