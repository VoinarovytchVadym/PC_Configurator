namespace PC_Configurator.models.rams.companies;

public interface IRamCompany
{
    public Ram CreateProduct(string type, int capacity, int numberOfModules, int frequency);
}