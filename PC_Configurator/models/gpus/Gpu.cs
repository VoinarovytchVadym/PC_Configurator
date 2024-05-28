using PC_Configurator.core;

namespace PC_Configurator.models.gpus;

public class Gpu(string processorFamily, string model, string vendor, string chip, int vram, string vramType)
{
    public int Id { get; set; }
    public string ProcessorFamily { get; set; } = processorFamily;
    public string Model { get; set; } = model;
    public string Vendor { get; set; } = vendor;
    public string Chip { get; set; } = chip;
    public int Vram { get; set; } = vram;
    public string VramType { get; set; } = vramType;
    public void SaveToDataBase()
    {
        DB db = DB.GetInstance();
        db.Gpus.Add(this);
        db.SaveChanges();
    }
}