namespace PC_Configurator.models.cpus.companies;

public class AMD : ICpuCompany
{
    public Cpu CreateProduct(string line, string socket, int coresNumber, int streamsNumber, double frequency, string? graphicsCore)
    {
        return new Cpu("AMD",line, socket, coresNumber, streamsNumber, frequency, graphicsCore);
    }
}