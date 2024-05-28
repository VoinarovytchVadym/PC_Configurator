using PC_Configurator.models.gpus.product;

namespace PC_Configurator.models.gpus.company;

public interface IGpuCompany
{
    public IGpu CreateProduct(string model, string vendor, string chip, int vram, string vramType);
}