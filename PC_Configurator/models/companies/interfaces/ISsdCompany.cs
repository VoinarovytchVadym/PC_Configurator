using PC_Configurator.models.products;

namespace PC_Configurator.models.companies.interfaces;

public interface ISsdCompany
{
    public Ssd CreateProduct(string formFactor, int memoryCapacity, string @interface,
        int readingSpeed, int recordingSpeed);
}