using PC_Configurator.core;

namespace PC_Configurator.models.products;

public class Motherboard(string producer, string forProcessors, string socket, string chipset, string formFactor, string memoryType, int memorySlotsNumber)
    : IProduct
{
    public int Id { get; set; }
    public string Producer { get; set; } = producer;
    public string ForProcessors { get; set; } = forProcessors;
    public string Socket { get; set; } = socket;
    public string Chipset { get; set; } = chipset;
    public string FormFactor { get; set; } = formFactor;
    public string MemoryType { get; set; } = memoryType;
    public int MemorySlotsNumber { get; set; } = memorySlotsNumber;

    public void SaveToDataBase()
    {
        Db db = Db.GetInstance();
        db.Motherboards.Add(this);
        db.SaveChanges();
    }
}