using PC_Configurator.models.products;

namespace PC_Configurator.models.pcs.builders;

public abstract class Builder : IPC
{
    protected PcConfiguration PcConfiguration = new();

    private void _reset()
    {
        this.PcConfiguration = new PcConfiguration();
    }

    public IPC ConfigurationNameIs(string name)
    {
        this.PcConfiguration.ConfigurationName = name;
        return this;
    }

    public IPC CpuIs(Cpu cpu)
    {
        this.PcConfiguration.CpuId = cpu.Id;
        return this;
    }

    public IPC GpuIs(Gpu gpu)
    {
        this.PcConfiguration.GpuId = gpu.Id;
        return this;
    }
    

    public IPC RamIs(Ram ram)
    {
        this.PcConfiguration.RamId = ram.Id;
        return this;
    }

    public PcConfiguration CreateConfiguration()
    {
        PcConfiguration configuration = this.PcConfiguration;
        this._reset();
        return configuration;
    }
}