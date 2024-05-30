namespace PC_Configurator.models.products;

public interface IProduct
{
    public int Id { get; set; }
    public void SaveToDataBase();
}