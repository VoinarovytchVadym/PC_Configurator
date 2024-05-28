namespace PC_Configurator.models.cpus.companies;

public interface ICpuCompany
{
    public Cpu CreateProduct(string line, string socket, int coresNumber, int streamsNumber, double frequency, string? graphicsCore);
}