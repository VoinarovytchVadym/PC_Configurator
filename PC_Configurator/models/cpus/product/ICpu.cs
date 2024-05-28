namespace PC_Configurator.models.cpus.product;

public interface ICpu
{
    public string Producer { get; set; }
    public string Line { get; set; }
    public string Socket { get; set; }
    public int CoresNumber { get; set; }
    public int StreamsNumber { get; set; }
    public double Frequency { get; set; }
    public string? GraphicsCore { get; set; }
}