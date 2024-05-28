using PC_Configurator.models.cpus;
using PC_Configurator.models.gpus;
using PC_Configurator.models.rams;

namespace PC_Configurator.models.pcs;

public interface IPC
{
    IPC ConfigurationNameIs(string name);
    IPC CpuIs(Cpu cpu);
    IPC GpuIs(Gpu gpu);
    IPC RamIs(Ram ram);
    PcConfiguration CreateConfiguration();
}