using System.Configuration;
using Microsoft.EntityFrameworkCore;
using WssСonsultingBl.Model;
using System.Configuration;

namespace WssСonsultingBl;

public class ApplicationContext : DbContext
{
    public DbSet<Company> Companies { get; set; } 
    
    public ApplicationContext()
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        optionsBuilder.UseSqlServer(connectionString);
    }
    
}