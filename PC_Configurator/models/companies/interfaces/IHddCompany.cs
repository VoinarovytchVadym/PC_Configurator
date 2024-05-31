using PC_Configurator.models.products;

namespace PC_Configurator.models.companies.interfaces;

public interface IHddCompany
{
    public Hdd CreateProduct(string formFactor, int memoryCapacity, string @interface, int rotatingSpeed, string fullName);
}