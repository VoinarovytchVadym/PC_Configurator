using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using PC_Configurator.core;
using PC_Configurator.models.cpus;
using PC_Configurator.models.cpus.companies;
using PC_Configurator.models.gpus;
using PC_Configurator.models.gpus.companies;
using PC_Configurator.models.pcs;
using PC_Configurator.models.pcs.builders;
using PC_Configurator.models.rams;
using PC_Configurator.models.rams.companies;
using PC_Configurator.views;
using AMD = PC_Configurator.models.gpus.companies.AMD;


namespace PC_Configurator;

public partial class MainWindow : Window
{
    private Gpu? _gpu;
    private Cpu? _cpu;
    public MainWindow()
    {
        DB db = DB.GetInstance();
    }

    private void ViewCurrentConfiguration(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
        MainFrame.Navigate(new CurrentConfigurationPage(_gpu));
    }

    private void GpuSave(object sender, Gpu selectedItem)
    {
        _gpu = selectedItem;
        MainFrame.Navigate(new CurrentConfigurationPage(_gpu));
    }

    private void UIElement_OnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
        GpuSelectionPage gpuSelectionPage = new GpuSelectionPage();
        gpuSelectionPage.ItemSelected += GpuSave;
        MainFrame.Navigate(gpuSelectionPage);
    }
}
