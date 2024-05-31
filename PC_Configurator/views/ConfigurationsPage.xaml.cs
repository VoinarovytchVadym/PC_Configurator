using PC_Configurator.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PC_Configurator.models.pcs;
using PC_Configurator.models.products;

namespace PC_Configurator.views;

public partial class ConfigurationsPage : Page
{
    private readonly Db _db = Db.GetInstance();
    private readonly List<PcConfiguration> _configurations;

    public ConfigurationsPage()
    {
        InitializeComponent();
        _configurations = _db.PcConfigurations.ToList();
        List<string> configurationNames = _db.PcConfigurations.Select(pc => pc.FullName).ToList();
        configSelect.ItemsSource = configurationNames;
    }

    private void ConfigSelect_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        PcConfiguration pcConfiguration = _db.PcConfigurations.FirstOrDefault(u => u.Id == _configurations[configSelect.SelectedIndex].Id)!;
        
        var isCpu = pcConfiguration.CpuId != null;
        var isGpu = pcConfiguration.GpuId != null;
        var isRam = pcConfiguration.RamId != null;
        var isMotherboard = pcConfiguration.MotherboardId != null;
        var isSsd = pcConfiguration.SsdId != null;
        var isHdd = pcConfiguration.HddId != null;
        var isPowerSupplie = pcConfiguration.PowerSupplieId != null;
        var isCase = pcConfiguration.CaseId != null;
        
        if (isCpu)
        {
            List<Cpu> cpu = [_db.Cpus.FirstOrDefault(u=>u.Id==pcConfiguration.CpuId)!];
            SelectedCpu.ItemsSource = cpu;
            SelectedCpu.Visibility = Visibility.Visible;
        }

        if (isGpu)
        {
            List<Gpu> gpu = [_db.Gpus.FirstOrDefault(u=>u.Id==pcConfiguration.GpuId)!];
            SelectedGpu.ItemsSource = gpu;
            SelectedGpu.Visibility = Visibility.Visible;
        }

        if (isRam)
        {
            List<Ram> ram = [_db.Rams.FirstOrDefault(u=>u.Id==pcConfiguration.RamId)!];
            SelectedRam.ItemsSource = ram;
            SelectedRam.Visibility = Visibility.Visible;
        }

        if (isMotherboard)
        {
            List<Motherboard> motherboards = [_db.Motherboards.FirstOrDefault(u=>u.Id==pcConfiguration.MotherboardId)!];
            SelectedMotherboard.ItemsSource = motherboards;
            SelectedMotherboard.Visibility = Visibility.Visible;
        }

        if (isSsd)
        {
            List<Ssd> ssds = [_db.Ssds.FirstOrDefault(u=>u.Id==pcConfiguration.SsdId)!];
            SelectedSsd.ItemsSource = ssds;
            SelectedSsd.Visibility = Visibility.Visible;
        }

        if (isHdd)
        {
            List<Hdd> hdds = [_db.Hdds.FirstOrDefault(u=>u.Id==pcConfiguration.HddId)!];
            SelectedHdd.ItemsSource = hdds;
            SelectedHdd.Visibility = Visibility.Visible;
        }

        if (isPowerSupplie)
        {
            List<PowerSupplie> powerSupplies = [_db.PowerSupplies.FirstOrDefault(u=>u.Id==pcConfiguration.PowerSupplieId)!];
            SelectedPowerSupplie.ItemsSource = powerSupplies;
            SelectedPowerSupplie.Visibility = Visibility.Visible;
        }

        if (isCase)
        {
            List<Case> cases = [_db.Cases.FirstOrDefault(u=>u.Id==pcConfiguration.CaseId)!];
            SelectedCase.ItemsSource = cases;
            SelectedCase.Visibility = Visibility.Visible;
        }
    }
}