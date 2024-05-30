using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using PC_Configurator.core;
using PC_Configurator.models.pcs;
using PC_Configurator.models.pcs.builders;
using PC_Configurator.models.products;
using PC_Configurator.views;


namespace PC_Configurator;

public partial class MainWindow : Window
{
    public static Gpu? Gpu;
    public static Cpu? Cpu;
    public static Ram? Ram;
    public static Motherboard? Motherboard;
    public static Ssd? Ssd;
    public static Hdd? Hdd;
    public static PowerSupplie? PowerSupplie;
    public static Case? Case;
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
    private void MotherboardSave(object sender, Motherboard selectedItem)
    {
        Motherboard = selectedItem;
        MotherboardLabel.Style = (Style)FindResource("CheckedCategoryLabel");
    }
    private void SsdSave(object sender, Ssd selectedItem)
    {
        Ssd = selectedItem;
        SsdLabel.Style = (Style)FindResource("CheckedCategoryLabel");
    }
    private void HddSave(object sender, Hdd selectedItem)
    {
        Hdd = selectedItem;
        HddLabel.Style = (Style)FindResource("CheckedCategoryLabel");
    }
    private void PowerSupplySave(object sender, PowerSupplie selectedItem)
    {
        PowerSupplie = selectedItem;
        PowerSupplyLabel.Style = (Style)FindResource("CheckedCategoryLabel");
    }
    private void CaseSave(object sender, Case selectedItem)
    {
        Case = selectedItem;
        CaseLabel.Style = (Style)FindResource("CheckedCategoryLabel");
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
        MotherboardSelectionPage motherboardSelectionPage = new MotherboardSelectionPage();
        motherboardSelectionPage.ItemSelected += MotherboardSave!;
        MainFrame.Navigate(motherboardSelectionPage);

    }

    private void PowerSupplyLabel_OnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void SsdLabel_OnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
        SsdSelectionPage ssdSelectionPage = new SsdSelectionPage();
        ssdSelectionPage.ItemSelected += SsdSave!;
        MainFrame.Navigate(ssdSelectionPage);
    }

    private void HddLabel_OnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
        HddSelectionPage hddSelectionPage = new HddSelectionPage();
        hddSelectionPage.ItemSelected += HddSave!;
        MainFrame.Navigate(hddSelectionPage);
    }

    private void CaseLabel_OnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
        throw new NotImplementedException();
    }
}
