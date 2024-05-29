using PC_Configurator.core;

namespace PC_Configurator.models.cpus;

public class Cpu(string producer, string line, string socket, int coresNumber, int streamsNumber, double frequency, string? graphicsCore)
    : IProduct
{
    public int Id { get; set; }
    public string Producer { get; set; } = producer;
    public string Line { get; set; } = line;
    public string Socket { get; set; } = socket;
    public int CoresNumber { get; set; } = coresNumber;
    public int StreamsNumber { get; set; } = streamsNumber;
    public double Frequency { get; set; } = frequency;
    public string? GraphicsCore { get; set; } = graphicsCore;

    public void SaveToDataBase()
    {
        Db db = Db.GetInstance();
        db.Cpus.Add(this);
        db.SaveChanges();
    }
}