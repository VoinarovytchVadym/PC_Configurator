using PC_Configurator.models.products;

namespace PC_Configurator.models.companies.interfaces;

public interface ICpuCompany
{
    public Cpu CreateProduct(string line, string socket, int coresNumber, int streamsNumber, double frequency, string? graphicsCore);
}