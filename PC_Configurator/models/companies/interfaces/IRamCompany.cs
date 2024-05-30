using PC_Configurator.models.products;

namespace PC_Configurator.models.companies.interfaces;

public interface IRamCompany
{
    public Ram CreateProduct(string type, int capacity, int numberOfModules, int frequency);
}