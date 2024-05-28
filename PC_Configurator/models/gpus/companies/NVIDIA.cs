

namespace PC_Configurator.models.gpus.companies;

public class NVIDIA : IGpuCompany
{
    public Gpu CreateProduct(string model, string vendor, string chip, int vram, string vramType)
    {
        return new Gpu("NVIDIA",model, vendor, chip, vram, vramType);
    }
}