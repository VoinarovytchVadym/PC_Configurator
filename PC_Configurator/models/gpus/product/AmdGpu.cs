namespace PC_Configurator.models.gpus.product;

public class AmdGpu : IGpu
{
    public int Id { get; set; }
    public string ProcessorFamily { get; set; }
    public string Model { get; set; }
    public string Vendor { get; set; }
    public string Chip { get; set; }
    public int Vram { get; set; }
    public string VramType { get; set; }

    public AmdGpu(string model, string vendor, string chip, int vram, string vramType)
    {
        ProcessorFamily = "AMD";
        Model = model;
        Vendor = vendor;
        Chip = chip;
        Vram = vram;
        VramType = vramType;
    }
    public AmdGpu()
    {
        ProcessorFamily = "AMD";
        Model = "none";
        Vendor = "none";
        Chip = "none";
        Vram = 0;
        VramType = "none";
    }
}