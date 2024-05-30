using PC_Configurator.models.products;

namespace PC_Configurator.models.companies.interfaces;

public interface ICaseCompany
{
    public Case CreateProduct(string size, string maxMotherboardFormFactor, string fullName);
}