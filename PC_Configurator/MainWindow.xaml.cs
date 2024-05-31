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

    private void CpuSave(object sender, Cpu selectedItem)
    {
        Cpu = selectedItem;
        CpuLabel.Style = (Style)FindResource("CheckedCategoryLabel");

    }
    private void CpuDelete(object sender, EventArgs e)
    {
        Cpu = null;
        CpuLabel.Style = (Style)FindResource("CategoryLabel");
    }
    
    
    private void GpuSave(object sender, Gpu selectedItem)
    {
        Gpu = selectedItem;
        GpuLabel.Style = (Style)FindResource("CheckedCategoryLabel");
    }
    private void GpuDelete(object sender, EventArgs e)
    {
        Gpu = null;
        GpuLabel.Style = (Style)FindResource("CategoryLabel");
    }
    
    
    private void RamSave(object sender, Ram selectedItem)
    {
        Ram = selectedItem;
        RamLabel.Style = (Style)FindResource("CheckedCategoryLabel");
    }
    private void RamDelete(object sender, EventArgs e)
    {
        Ram = null;
        RamLabel.Style = (Style)FindResource("CategoryLabel");
    }
    
    
    private void MotherboardSave(object sender, Motherboard selectedItem)
    {
        Motherboard = selectedItem;
        MotherboardLabel.Style = (Style)FindResource("CheckedCategoryLabel");
    }
    private void MotherboardDelete(object sender, EventArgs e)
    {
        Motherboard = null;
        MotherboardLabel.Style = (Style)FindResource("CategoryLabel");
    }
    
    
    private void SsdSave(object sender, Ssd selectedItem)
    {
        Ssd = selectedItem;
        SsdLabel.Style = (Style)FindResource("CheckedCategoryLabel");
    }
    private void SsdDelete(object sender, EventArgs e)
    {
        Ssd = null;
        SsdLabel.Style = (Style)FindResource("CategoryLabel");
    }
    
    
    private void HddSave(object sender, Hdd selectedItem)
    {
        Hdd = selectedItem;
        HddLabel.Style = (Style)FindResource("CheckedCategoryLabel");
    }
    private void HddDelete(object sender, EventArgs e)
    {
        Hdd = null;
        HddLabel.Style = (Style)FindResource("CategoryLabel");
    }
    
    
    private void PowerSupplieSave(object sender, PowerSupplie selectedItem)
    {
        PowerSupplie = selectedItem;
        PowerSupplyLabel.Style = (Style)FindResource("CheckedCategoryLabel");
    }
    private void PowerSupplieDelete(object sender, EventArgs e)
    {
        PowerSupplie = null;
        PowerSupplyLabel.Style = (Style)FindResource("CategoryLabel");
    }
    
    
    private void CaseSave(object sender, Case selectedItem)
    {
        Case = selectedItem;
        CaseLabel.Style = (Style)FindResource("CheckedCategoryLabel");
    }
    private void CaseDelete(object sender, EventArgs e)
    {
        Case = null;
        CaseLabel.Style = (Style)FindResource("CategoryLabel");
    }
    private void CpuLabel_OnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
        CpuSelectionPage cpuSelectionPage = new CpuSelectionPage();
        cpuSelectionPage.ItemSelected += CpuSave!;
        cpuSelectionPage.DeleteSelection += CpuDelete!;
        MainFrame.Navigate(cpuSelectionPage);
    }

    private void GpuLabel_OnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
        GpuSelectionPage gpuSelectionPage = new GpuSelectionPage();
        gpuSelectionPage.ItemSelected += GpuSave!;
        gpuSelectionPage.DeleteSelection += GpuDelete!;
        MainFrame.Navigate(gpuSelectionPage);
    }
    
    private void RamLabel_OnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
        RamSelectionPage ramSelectionPage = new RamSelectionPage();
        ramSelectionPage.ItemSelected += RamSave!;
        ramSelectionPage.DeleteSelection += RamDelete!;
        MainFrame.Navigate(ramSelectionPage);
    }

    private void MotherboardLabel_OnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
        MotherboardSelectionPage motherboardSelectionPage = new MotherboardSelectionPage();
        motherboardSelectionPage.ItemSelected += MotherboardSave!;
        motherboardSelectionPage.DeleteSelection += MotherboardDelete!;
        MainFrame.Navigate(motherboardSelectionPage);
    }


    private void SsdLabel_OnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
        SsdSelectionPage ssdSelectionPage = new SsdSelectionPage();
        ssdSelectionPage.ItemSelected += SsdSave!;
        ssdSelectionPage.DeleteSelection += SsdDelete!;
        MainFrame.Navigate(ssdSelectionPage);
    }

    private void HddLabel_OnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
        HddSelectionPage hddSelectionPage = new HddSelectionPage();
        hddSelectionPage.ItemSelected += HddSave!;
        hddSelectionPage.DeleteSelection += HddDelete!;
        MainFrame.Navigate(hddSelectionPage);
    }
    private void PowerSupplyLabel_OnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
        PowerSupplieSelectionPage powerSupplieSelectionPage = new PowerSupplieSelectionPage();
        powerSupplieSelectionPage.ItemSelected += PowerSupplieSave!;
        powerSupplieSelectionPage.DeleteSelection += PowerSupplieDelete!;
        MainFrame.Navigate(powerSupplieSelectionPage);
    }

    private void CaseLabel_OnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
        CaseSelectionPage caseSelectionPage = new CaseSelectionPage();
        caseSelectionPage.ItemSelected += CaseSave!;
        caseSelectionPage.DeleteSelection += CaseDelete!;
        MainFrame.Navigate(caseSelectionPage);
    }

    private void Configurations_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
        MainFrame.Navigate(new ConfigurationsPage());
    }
}
