

namespace PC_Configurator.models.gpus.companies;

public interface IGpuCompany
{
    public Gpu CreateProduct(string model, string vendor, string chip, int vram, string vramType);
}