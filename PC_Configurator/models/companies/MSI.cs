using PC_Configurator.models.companies.interfaces;
using PC_Configurator.models.products;

namespace PC_Configurator.models.companies;

public class MSI : IMotherboardCompany
{
    public Motherboard CreateProduct(string forProcessors, string socket, string chipset, string formFactor, string memoryType,
        int memorySlotsNumber)
    {
        return new Motherboard("MSI", forProcessors, socket, chipset, formFactor, memoryType, memorySlotsNumber);
    }
}