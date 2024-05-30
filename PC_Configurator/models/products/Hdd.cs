using PC_Configurator.core;

namespace PC_Configurator.models.products;

public class Hdd(string producer, string formFactor, int memoryCapacity, string @interface, int rotatingSpeed)
    : IProduct
{
    public int Id { get; set; }
    public string Producer { get; set; } = producer;
    public string FormFactor { get; set; } = formFactor;
    public int MemoryCapacity { get; set; } = memoryCapacity;
    public string Interface { get; set; } = @interface;
    public int RotatingSpeed { get; set; } = rotatingSpeed;

    public void SaveToDataBase()
    {
        Db db = Db.GetInstance();
        db.Hdds.Add(this);
        db.SaveChanges();
    }
}