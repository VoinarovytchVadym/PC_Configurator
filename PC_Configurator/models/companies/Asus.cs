using PC_Configurator.models.companies.interfaces;
using PC_Configurator.models.products;

namespace PC_Configurator.models.companies;

public class Asus : IMotherboardCompany
{
    public Motherboard CreateProduct(string forProcessors, string socket, string chipset, string formFactor, string memoryType,
        int memorySlotsNumber)
    {
        return new Motherboard("Asus", forProcessors, socket, chipset, formFactor, memoryType, memorySlotsNumber);
    }
}