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

    public CurrentConfigurationPage()
    {
        InitializeComponent();
        var isCpu = MainWindow.Cpu != null;
        var isGpu = MainWindow.Gpu != null;
        var isRam = MainWindow.Ram != null;
        var isMotherboard = MainWindow.Motherboard != null;
        var isSsd = MainWindow.Ssd != null;
        var isHdd = MainWindow.Hdd != null;
        var isPowerSupplie = MainWindow.PowerSupplie != null;
        var isCase = MainWindow.Case != null;

        if (isCpu)
        {
            List<Cpu> cpu = [MainWindow.Cpu];
            SelectedCpu.ItemsSource = cpu;
            SelectedCpu.Visibility = Visibility.Visible;
        }

        if (isGpu)
        {
            List<Gpu> gpu = [MainWindow.Gpu];
            SelectedGpu.ItemsSource = gpu;
            SelectedGpu.Visibility = Visibility.Visible;
        }

        if (isRam)
        {
            List<Ram> ram = [MainWindow.Ram];
            SelectedRam.ItemsSource = ram;
            SelectedRam.Visibility = Visibility.Visible;
        }

        if (isMotherboard)
        {
            List<Motherboard> motherboards = [MainWindow.Motherboard];
            SelectedMotherboard.ItemsSource = motherboards;
            SelectedMotherboard.Visibility = Visibility.Visible;
        }

        if (isSsd)
        {
            List<Ssd> ssds = [MainWindow.Ssd];
            SelectedSsd.ItemsSource = ssds;
            SelectedSsd.Visibility = Visibility.Visible;
        }

        if (isHdd)
        {
            List<Hdd> hdds = [MainWindow.Hdd];
            SelectedHdd.ItemsSource = hdds;
            SelectedHdd.Visibility = Visibility.Visible;
        }

        if (isPowerSupplie)
        {
            List<PowerSupplie> powerSupplies = [MainWindow.PowerSupplie];
            SelectedPowerSupplie.ItemsSource = powerSupplies;
            SelectedPowerSupplie.Visibility = Visibility.Visible;
        }

        if (isCase)
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