using PC_Configurator.models.gpus.product;

namespace PC_Configurator.models.gpus.company;

public class AMD : IGpuCompany
{
    public IGpu CreateProduct(string model, string vendor, string chip, int vram, string vramType)
    {
        return new AmdGpu(model, vendor, chip, vram, vramType);
    }
}