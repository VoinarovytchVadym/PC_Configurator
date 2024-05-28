namespace PC_Configurator.models.cpus.product;

public class IntelCpu(string line, string socket, int coresNumber, int streamsNumber, double frequency, string? graphicsCore)
    : ICpu
{
    public int Id { get; set; }
    public string Producer { get; set; } = "Intel";
    public string Line { get; set; } = line;
    public string Socket { get; set; } = socket;
    public int CoresNumber { get; set; } = coresNumber;
    public int StreamsNumber { get; set; } = streamsNumber;
    public double Frequency { get; set; } = frequency;
    public string? GraphicsCore { get; set; } = graphicsCore;
}