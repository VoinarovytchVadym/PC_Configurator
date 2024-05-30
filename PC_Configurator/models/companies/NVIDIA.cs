

using PC_Configurator.models.companies.interfaces;
using PC_Configurator.models.products;

namespace PC_Configurator.models.companies;

public class NVIDIA : IGpuCompany
{
    public Gpu CreateProduct(string model, string vendor, string chip, int vram, string vramType, string fullName)
    {
        return new Gpu("NVIDIA",model, vendor, chip, vram, vramType, fullName);
    }
}