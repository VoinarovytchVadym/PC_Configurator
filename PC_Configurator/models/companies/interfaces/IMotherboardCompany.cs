using PC_Configurator.models.products;

namespace PC_Configurator.models.companies.interfaces;

public interface IMotherboardCompany
{
    public Motherboard CreateProduct(string forProcessors, string socket, string chipset, string formFactor,
        string memoryType, int memorySlotsNumber, string fullName);
}