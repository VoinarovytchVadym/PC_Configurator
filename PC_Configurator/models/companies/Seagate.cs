using PC_Configurator.models.companies.interfaces;
using PC_Configurator.models.products;

namespace PC_Configurator.models.companies;

public class Seagate : IHddCompany
{
    public Hdd CreateProduct(string formFactor, int memoryCapacity, string @interface, int rotatingSpeed)
    {
        return new Hdd("Seagate", formFactor, memoryCapacity, @interface, rotatingSpeed);
    }
}