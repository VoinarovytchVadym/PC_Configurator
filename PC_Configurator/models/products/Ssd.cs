using PC_Configurator.core;

namespace PC_Configurator.models.products;

public class Ssd(
    string producer,
    string formFactor,
    int memoryCapacity,
    string @interface,
    int readingSpeed,
    int recordingSpeed,
    string fullName)
    : IProduct
{
    public int Id { get; set; }
    public string FullName { get; set; } = fullName;
    public string Producer { get; set; } = producer;
    public string FormFactor { get; set; } = formFactor;
    public int MemoryCapacity { get; set; } = memoryCapacity;
    public string Interface { get; set; } = @interface;
    public int ReadingSpeed { get; set; } = readingSpeed;
    public int RecordingSpeed { get; set; } = recordingSpeed;

    public void SaveToDataBase()
    {
        Db db = Db.GetInstance();
        db.Ssds.Add(this);
        db.SaveChanges();
    }
}