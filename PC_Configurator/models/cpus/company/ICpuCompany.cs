using PC_Configurator.models.cpus.product;

namespace PC_Configurator.models.cpus.company;

public interface ICpuCompany
{
    public ICpu CreateProduct(string line, string socket, int coresNumber, int streamsNumber, double frequency, string? graphicsCore);
}