using lab4.Data;
using lab4.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace lab04.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

//Injection of Models (via. Entity Framework Core)
 protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);
   
        modelBuilder.Entity<City>().HasData(SampleData.GetCities());
        modelBuilder.Entity<Province>().HasData(SampleData.GetProvinces());
    }
    public DbSet<City>? Cities { get; set; }
    public DbSet<Province>? Province { get; set; }  
}
