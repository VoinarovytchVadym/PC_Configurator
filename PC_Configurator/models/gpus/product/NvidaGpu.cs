namespace PC_Configurator.models.gpus.product;

public class NvidaGpu : IGpu
{
    public int Id { get; set; }
    public string ProcessorFamily { get; set; }
    public string Model { get; set; }
    public string Vendor { get; set; }
    public string Chip { get; set; }
    public int Vram { get; set; }
    public string VramType { get; set; }

    public NvidaGpu(string model, string vendor, string chip, int vram, string vramType)
    {
        ProcessorFamily = "NVIDIA";
        Model = model;
        Vendor = vendor;
        Chip = chip;
        Vram = vram;
        VramType = vramType;
    }
    public NvidaGpu()
    {
        ProcessorFamily = "NVIDIA";
        Model = "none";
        Vendor = "none";
        Chip = "none";
        Vram = 0;
        VramType = "none";
    }

}