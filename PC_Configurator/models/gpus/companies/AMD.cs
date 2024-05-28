

namespace PC_Configurator.models.gpus.companies;

public class AMD : IGpuCompany
{
    public Gpu CreateProduct(string model, string vendor, string chip, int vram, string vramType)
    {
        return new Gpu("AMD",model, vendor, chip, vram, vramType);
    }
}