using PC_Configurator.core;
using PC_Configurator.models.products;

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
        Db db = Db.GetInstance();
        db.PcConfigurations.Add(this);
        db.SaveChanges();
    }
}