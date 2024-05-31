using PC_Configurator.models.products;

namespace PC_Configurator.models.pcs;

public interface IPC
{
    IPC ConfigurationNameIs(string name);
    IPC CpuIs(Cpu cpu);
    IPC GpuIs(Gpu gpu);
    IPC RamIs(Ram ram);
    IPC MotherboardIs(Motherboard motherboard);
    IPC SsdIs(Ssd ssd);
    IPC HddIs(Hdd hdd);
    IPC PowerSupplieIs(PowerSupplie powerSupplie);
    IPC CaseIs(Case @case);
    PcConfiguration CreateConfiguration();
}