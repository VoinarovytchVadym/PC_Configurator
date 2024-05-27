using PC_Configurator.models.gpus.product;

namespace PC_Configurator.models.gpus.company;

public class NVIDIA : ICompany
{
    public IGpu CreateProduct(string model, string vendor, string chip, int vram, string vramType)
    {
        return new NvidaGpu(model, vendor, chip, vram, vramType);
    }
}