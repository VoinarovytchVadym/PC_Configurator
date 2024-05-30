using PC_Configurator.models.companies.interfaces;
using PC_Configurator.models.products;

namespace PC_Configurator.models.companies;

public class Kingston : IRamCompany
{
    public Ram CreateProduct(string type, int capacity, int numberOfModules, int frequency, string fullName)
    {
        return new Ram("Kingston",type, capacity, numberOfModules, frequency, fullName);
    }
}