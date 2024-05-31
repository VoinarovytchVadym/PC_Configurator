using System.Collections.Immutable;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using PC_Configurator.core;
using PC_Configurator.models.pcs;
using PC_Configurator.models.pcs.builders;
using PC_Configurator.models.products;

namespace PC_Configurator.views;

public partial class CurrentConfigurationPage : Page
{
    private Db db = Db.GetInstance();
    private bool IsCpu;
    private bool IsGpu;
    private bool IsRam;
    private bool IsMotherboard;
    private bool IsSsd;
    private bool IsHdd;
    private bool IsPowerSupplie;
    private bool IsCase;

    public CurrentConfigurationPage()
    {
        InitializeComponent();
        IsCpu = MainWindow.Cpu != null;
        IsGpu = MainWindow.Gpu != null;
        IsRam = MainWindow.Ram != null;
        IsMotherboard = MainWindow.Motherboard != null;
        IsSsd = MainWindow.Ssd != null;
        IsHdd = MainWindow.Hdd != null;
        IsPowerSupplie = MainWindow.PowerSupplie != null;
        IsCase = MainWindow.Case != null;

        if (IsCpu)
        {
            List<Cpu> cpu = [MainWindow.Cpu];
            SelectedCpu.ItemsSource = cpu;
            SelectedCpu.Visibility = Visibility.Visible;
        }

        if (IsGpu)
        {
            List<Gpu> gpu = [MainWindow.Gpu];
            SelectedGpu.ItemsSource = gpu;
            SelectedGpu.Visibility = Visibility.Visible;
        }

        if (IsRam)
        {
            List<Ram> ram = [MainWindow.Ram];
            SelectedRam.ItemsSource = ram;
            SelectedRam.Visibility = Visibility.Visible;
        }

        if (IsMotherboard)
        {
            List<Motherboard> motherboards = [MainWindow.Motherboard];
            SelectedMotherboard.ItemsSource = motherboards;
            SelectedMotherboard.Visibility = Visibility.Visible;
        }

        if (IsSsd)
        {
            List<Ssd> ssds = [MainWindow.Ssd];
            SelectedSsd.ItemsSource = ssds;
            SelectedSsd.Visibility = Visibility.Visible;
        }

        if (IsHdd)
        {
            List<Hdd> hdds = [MainWindow.Hdd];
            SelectedHdd.ItemsSource = hdds;
            SelectedHdd.Visibility = Visibility.Visible;
        }

        if (IsPowerSupplie)
        {
            List<PowerSupplie> powerSupplies = [MainWindow.PowerSupplie];
            SelectedPowerSupplie.ItemsSource = powerSupplies;
            SelectedPowerSupplie.Visibility = Visibility.Visible;
        }

        if (IsCase)
        {
            List<Case> cases = [MainWindow.Case];
            SelectedCase.ItemsSource = cases;
            SelectedCase.Visibility = Visibility.Visible;
        }
    }

    private void SaveButton_OnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
        string trimmedName = ConfigurationName.Text.Trim();
        PcConfiguration configuration = ConfigurationBuilder.Create()
            .CpuIs(MainWindow.Cpu)
            .GpuIs(MainWindow.Gpu)
            .RamIs(MainWindow.Ram)
            .MotherboardIs(MainWindow.Motherboard)
            .SsdIs(MainWindow.Ssd)
            .HddIs(MainWindow.Hdd)
            .PowerSupplieIs(MainWindow.PowerSupplie)
            .CaseIs(MainWindow.Case)
            .ConfigurationNameIs(trimmedName != string.Empty ? trimmedName : "New")
            .CreateConfiguration();
        configuration.SaveToDataBase();
        NavigationService.Content = null;
    }
}