using PC_Configurator.core;

namespace PC_Configurator.models.pcs;

public class PcConfiguration : IProduct
{
    public int Id { get; set; }
    public string ConfigurationName { get; set; } = "Configuration";
    public int? GpuId { get; set; } = null;
    public int? CpuId { get; set; } = null;
    public int? RamId { get; set; } = null;
    public void SaveToDataBase()
    {
        DB db = DB.GetInstance();
        db.PcConfigurations.Add(this);
        db.SaveChanges();
    }
}