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
    public static Gpu? Gpu;
    public static Cpu? Cpu;
    public static Ram? Ram;
    public MainWindow()
    {
        InitializeComponent();
    }

    private void ViewCurrentConfiguration(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
        MainFrame.Navigate(new CurrentConfigurationPage());
    }

    private void GpuSave(object sender, Gpu selectedItem)
    {
        Gpu = selectedItem;
        GpuLabel.Style = (Style)FindResource("CheckedCategoryLabel");
    }
    private void CpuSave(object sender, Cpu selectedItem)
    {
        Cpu = selectedItem;
        CpuLabel.Style = (Style)FindResource("CheckedCategoryLabel");

    }
    private void RamSave(object sender, Ram selectedItem)
    {
        Ram = selectedItem;
        RamLabel.Style = (Style)FindResource("CheckedCategoryLabel");
    }
    private void MotherboardSave(object sender, Cpu selectedItem)
    {
        throw new NotImplementedException();
    }
    private void SsdSave(object sender, Cpu selectedItem)
    {
        throw new NotImplementedException();
    }
    private void HddSave(object sender, Cpu selectedItem)
    {
        throw new NotImplementedException();
    }
    private void PowerSupplySave(object sender, Cpu selectedItem)
    {
        throw new NotImplementedException();
    }
    private void CaseSave(object sender, Cpu selectedItem)
    {
        throw new NotImplementedException();
    }

    private void GpuLabel_OnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
        GpuSelectionPage gpuSelectionPage = new GpuSelectionPage();
        gpuSelectionPage.ItemSelected += GpuSave!;
        MainFrame.Navigate(gpuSelectionPage);
    }
    
    private void CpuLabel_OnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
        CpuSelectionPage cpuSelectionPage = new CpuSelectionPage();
        cpuSelectionPage.ItemSelected += CpuSave!;
        MainFrame.Navigate(cpuSelectionPage);
    }

    private void RamLabel_OnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
        RamSelectionPage ramSelectionPage = new RamSelectionPage();
        ramSelectionPage.ItemSelected += RamSave!;
        MainFrame.Navigate(ramSelectionPage);
    }

    private void MotherboardLabel_OnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void PowerSupplyLabel_OnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void SsdLabel_OnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void HddLabel_OnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void CaseLabel_OnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
        throw new NotImplementedException();
    }
}
