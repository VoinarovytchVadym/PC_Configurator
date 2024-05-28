using System.Windows;
using PC_Configurator.core;
using PC_Configurator.models.cpus;
using PC_Configurator.models.cpus.companies;
using PC_Configurator.models.gpus;
using PC_Configurator.models.gpus.companies;
using PC_Configurator.models.pcs;
using PC_Configurator.models.pcs.builders;
using PC_Configurator.models.rams;
using PC_Configurator.models.rams.companies;
using AMD = PC_Configurator.models.gpus.companies.AMD;


namespace PC_Configurator;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        DB db = DB.GetInstance();
        IRamCompany ramCompany = new Kingston();
        ICpuCompany cpuCompany = new Intel();
        IGpuCompany gpuCompany = new NVIDIA();
        Cpu cpu = cpuCompany.CreateProduct("line", "socket", 4, 8, 3.6, null);
        Gpu gpu = gpuCompany.CreateProduct("model", "vendor", "chip", 10, "Type");
        Ram ram = ramCompany.CreateProduct("type", 16, 2, 3200);

        cpu.Id = 1;
        gpu.Id = 1;
        ram.Id = 1;
        
        PcConfiguration pc = ConfigurationBuilder.Create().ConfigurationNameIs("name")
            .CpuIs(cpu).GpuIs(gpu).RamIs(ram).CreateConfiguration();
        pc.SaveToDataBase();
    }
}
