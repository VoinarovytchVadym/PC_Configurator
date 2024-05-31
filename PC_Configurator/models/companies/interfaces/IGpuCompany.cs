

using PC_Configurator.models.products;

namespace PC_Configurator.models.companies.interfaces;

public interface IGpuCompany
{
    public Gpu CreateProduct(string model, string vendor, string chip, int vram, string vramType, string fullName);
}