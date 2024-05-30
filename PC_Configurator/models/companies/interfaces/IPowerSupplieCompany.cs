using PC_Configurator.models.products;

namespace PC_Configurator.models.companies.interfaces;

public interface IPowerSupplieCompany
{
    public PowerSupplie CreateProduct(string formFactor, int power);
}