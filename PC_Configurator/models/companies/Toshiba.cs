using PC_Configurator.models.companies.interfaces;
using PC_Configurator.models.products;

namespace PC_Configurator.models.companies;

public class Toshiba : IHddCompany
{
    public Hdd CreateProduct(string formFactor, int memoryCapacity, string @interface, int rotatingSpeed, string fullName)
    {
        return new Hdd("Toshiba", formFactor, memoryCapacity, @interface, rotatingSpeed, fullName);
    }
}