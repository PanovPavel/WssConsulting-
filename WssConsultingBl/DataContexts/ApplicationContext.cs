using System.Configuration;
using Microsoft.EntityFrameworkCore;
using WssСonsultingBl.Models;

namespace WssСonsultingBl.DataContexts;

public  class ApplicationContext : DbContext
{
    public DbSet<Company> Companies { get; set; } 
    public DbSet<Department> Departments { get; set; }
    public DbSet<Division> Divisions { get; set; }
    
    public ApplicationContext()
    {
        //Database.EnsureDeleted();
        Database.EnsureCreated();
    }
    
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {
        //Database.EnsureDeleted();
        Database.EnsureCreated();
    }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        optionsBuilder.UseSqlServer(connectionString);
    }
    
}