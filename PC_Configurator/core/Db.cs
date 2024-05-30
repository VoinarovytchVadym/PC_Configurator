using Microsoft.EntityFrameworkCore;
using PC_Configurator.models.pcs;
using PC_Configurator.models.products;

namespace PC_Configurator.core;

sealed class Db : DbContext
{
    public DbSet<Gpu> Gpus { get; set; }
    public DbSet<Cpu> Cpus { get; set; }
    public DbSet<Ram> Rams { get; set; }
    public DbSet<Case> Cases { get; set; }
    public DbSet<Ssd> Ssds { get; set; }
    public DbSet<Hdd> Hdds { get; set; }
    public DbSet<Motherboard> Motherboards { get; set; }
    public DbSet<PowerSupplie> PowerSupplies { get; set; }
    
    public DbSet<PcConfiguration> PcConfigurations { get; set; }
    
    private static Db? _db;
    private static readonly object RefObj = new object();
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=PC_Configurator;Integrated Security=True;TrustServerCertificate=True;");
    }
    
    public static Db GetInstance()
    {
        if (_db == null)
        {
            lock (RefObj)
            {
                _db ??= new Db();
            }
        }
        return _db;
    }
}