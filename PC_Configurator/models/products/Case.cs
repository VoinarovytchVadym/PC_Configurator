using PC_Configurator.core;

namespace PC_Configurator.models.products;

public class Case(string producer, string size, string maxMotherboardFormFactor)
    : IProduct
{
    public int Id { get; set; }
    public string Producer { get; set; } = producer;
    public string Size { get; set; } = size;
    public string MaxMotherboardFormFactor { get; set; } = maxMotherboardFormFactor;

    public void SaveToDataBase()
    {
        Db db = Db.GetInstance();
        db.Cases.Add(this);
        db.SaveChanges();
    }
}