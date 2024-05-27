

using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using User = PC_Configurator.models.User;

namespace PC_Configurator.core;

sealed class DB : DbContext
{
    public DbSet<User> Users { get; set; }
    
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