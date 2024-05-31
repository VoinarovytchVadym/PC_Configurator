using PC_Configurator.models.companies.interfaces;
using PC_Configurator.models.products;

namespace PC_Configurator.models.companies;

public class Intel : ICpuCompany
{
    public Cpu CreateProduct(string line, string socket, int coresNumber, int streamsNumber, double frequency, string? graphicsCore, string fullName)
    {
        return new Cpu("Intel", line, socket, coresNumber, streamsNumber, frequency, graphicsCore,fullName);
    }
}