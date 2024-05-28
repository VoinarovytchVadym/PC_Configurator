namespace PC_Configurator.models.pcs.builders;

public class ConfigurationBuilder
{
    public static IPC Create()
    {
        return new PC();
    }
    private class PC : Builder
    {
        
    }
}
