namespace PC_Configurator.models.rams.companies;

public class Kingston : IRamCompany
{
    public Ram CreateProduct(string type, int capacity, int numberOfModules, int frequency)
    {
        return new Ram("Kingston",type, capacity, numberOfModules, frequency);
    }
}