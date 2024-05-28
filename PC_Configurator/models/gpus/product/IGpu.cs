namespace PC_Configurator.models.gpus.product;

public interface IGpu
{
    public int Id { get; set; }
    public string ProcessorFamily { get; set; }
    public string Model { get; set; }
    public string Vendor { get; set; }
    public string Chip { get; set; }
    public int Vram { get; set; }
    public string VramType { get; set; }
}