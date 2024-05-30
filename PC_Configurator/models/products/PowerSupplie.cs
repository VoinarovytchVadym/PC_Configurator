using PC_Configurator.core;

namespace PC_Configurator.models.products;

public class PowerSupplie(string producer, string formFactor, int power) : IProduct
{
    public int Id { get; set; }
    public string Producer { get; set; } = producer;
    public string FormFactor { get; set; } = formFactor;
    public int Power { get; set; } = power;

    public void SaveToDataBase()
    {
        Db db = Db.GetInstance();
        db.PowerSupplies.Add(this);
        db.SaveChanges();
    }
}