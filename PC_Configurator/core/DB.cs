

using System.Windows.Forms.VisualStyles;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using PC_Configurator.models;
using PC_Configurator.models.cpus.product;
using PC_Configurator.models.gpus.product;

namespace PC_Configurator.core;

sealed class DB : DbContext
{
    public DbSet<NvidaGpu> NvidiaGpus { get; set; }
    public DbSet<AmdGpu> AmdGpus { get; set; }
    public DbSet<IntelCpu> IntelCpus { get; set; }
    public DbSet<AmdCpu> AmdCpus { get; set; }
    
    private static DB? _db;
    private static readonly object RefObj = new object();
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=PC_Configurator;Integrated Security=True;TrustServerCertificate=True;");
    }
    
    public static DB GetInstance()
    {
        if (_db == null)
        {
            lock (RefObj)
            {
                _db ??= new DB();
            }
        }
        return _db;
    }
}