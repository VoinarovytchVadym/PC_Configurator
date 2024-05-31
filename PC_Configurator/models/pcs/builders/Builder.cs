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
        this.PcConfiguration.FullName = name ?? throw new ArgumentNullException(nameof(name));
        return this;
    }

    public IPC CpuIs(Cpu? cpu)
    {
        if (cpu == null)
            this.PcConfiguration.CpuId = null;
        else
            this.PcConfiguration.CpuId = cpu.Id;
        return this;
    }

    public IPC GpuIs(Gpu? gpu)
    {
        if (gpu == null)
            this.PcConfiguration.GpuId = null;
        else             
            this.PcConfiguration.GpuId = gpu.Id;
        return this;
    }
    

    public IPC RamIs(Ram? ram)
    {
        if (ram == null)
            this.PcConfiguration.RamId = null;
        else             
            this.PcConfiguration.RamId = ram.Id;
        return this;
    }

    public IPC MotherboardIs(Motherboard? motherboard)
    {
        if (motherboard == null)
            this.PcConfiguration.MotherboardId = null;
        else
            this.PcConfiguration.MotherboardId = motherboard.Id;
        return this;
    }

    public IPC SsdIs(Ssd? ssd)
    {
        if (ssd == null)
            this.PcConfiguration.SsdId = null;
        else
            this.PcConfiguration.SsdId = ssd.Id;
        return this;
    }

    public IPC HddIs(Hdd? hdd)
    {
        if (hdd == null)
            this.PcConfiguration.HddId = null;
        else
            this.PcConfiguration.HddId = hdd.Id;
        return this;
    }

    public IPC PowerSupplieIs(PowerSupplie? powerSupplie)
    {
        if (powerSupplie == null)
            this.PcConfiguration.PowerSupplieId = null;
        else
            this.PcConfiguration.PowerSupplieId = powerSupplie.Id;
        return this;
    }

    public IPC CaseIs(Case? @case)
    {
        if (@case == null)
            this.PcConfiguration.CaseId = null;
        else
            this.PcConfiguration.CaseId = @case.Id;
        return this;
    }

    public PcConfiguration CreateConfiguration()
    {
        PcConfiguration configuration = this.PcConfiguration;
        this._reset();
        return configuration;
    }
}