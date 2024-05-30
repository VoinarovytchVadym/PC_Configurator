using PC_Configurator.models.companies.interfaces;
using PC_Configurator.models.products;

namespace PC_Configurator.models.companies;

public class Bequiet : ICaseCompany, IPowerSupplieCompany
{
    public Case CreateProduct(string size, string maxMotherboardFormFactor)
    {
        return new Case("bequiet!", size, maxMotherboardFormFactor);
    }

    public PowerSupplie CreateProduct(string formFactor, int power)
    {
        return new PowerSupplie("bequiet!", formFactor, power);
    }
}