using PC_Configurator.models.cpus.product;

namespace PC_Configurator.models.cpus.company;

public class AMD : ICpuCompany
{
    public ICpu CreateProduct(string line, string socket, int coresNumber, int streamsNumber, double frequency, string? graphicsCore)
    {
        return new AmdCpu(line, socket, coresNumber, streamsNumber, frequency, graphicsCore);
    }
}