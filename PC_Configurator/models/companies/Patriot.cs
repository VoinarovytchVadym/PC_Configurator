using PC_Configurator.models.companies.interfaces;
using PC_Configurator.models.products;

namespace PC_Configurator.models.companies;

public class Patriot : IRamCompany
{
    public Ram CreateProduct(string type, int capacity, int numberOfModules, int frequency, string fullName)
    {
        return new Ram("Patriot",type, capacity, numberOfModules, frequency, fullName);
    }
}