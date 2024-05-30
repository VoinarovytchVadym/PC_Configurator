using PC_Configurator.models.products;

namespace PC_Configurator.models.pcs;

public interface IPC
{
    IPC ConfigurationNameIs(string name);
    IPC CpuIs(Cpu cpu);
    IPC GpuIs(Gpu gpu);
    IPC RamIs(Ram ram);
    PcConfiguration CreateConfiguration();
}