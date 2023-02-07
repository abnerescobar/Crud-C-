using Microsoft.EntityFrameworkCore;
using DeliveryAPI.Entity;
using DeliveryAPI.Data.Configuration;

namespace DeliveryAPI.Data;
public class DeliveryDbContext : DbContext{
    public DeliveryDbContext(DbContextOptions options): base(options){}
    public DbSet<Customer> Customers {get; set;}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        ModelBuilder modelBuilder1 = modelBuilder.ApplyConfiguration(new CustomerConfiguration());
    }
}