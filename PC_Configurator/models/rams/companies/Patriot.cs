namespace PC_Configurator.models.rams.companies;

public class Patriot : IRamCompany
{
    public Ram CreateProduct(string type, int capacity, int numberOfModules, int frequency)
    {
        return new Ram("Patriot",type, capacity, numberOfModules, frequency);
    }
}