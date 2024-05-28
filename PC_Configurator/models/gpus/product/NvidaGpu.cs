namespace PC_Configurator.models.gpus.product;

public class NvidaGpu(string model, string vendor, string chip, int vram, string vramType)
    : IGpu
{
    public int Id { get; set; }
    public string ProcessorFamily { get; set; } = "NVIDIA";
    public string Model { get; set; } = model;
    public string Vendor { get; set; } = vendor;
    public string Chip { get; set; } = chip;
    public int Vram { get; set; } = vram;
    public string VramType { get; set; } = vramType;
}