using System.Data.Entity.Infrastructure;
using Microsoft.EntityFrameworkCore;
using thriftShop_API.Models.DAO;

namespace thriftShop_API.Data;

public class ThriftShopContext: DbContext
{
    public ThriftShopContext(DbContextOptions<ThriftShopContext> options) : base(options)
    {
        
    }
    
    public DbSet<Address>? Addresses { get; set; }
    public DbSet<Customer>? Customers { get; set; }
    public DbSet<Order>? Orders { get; set; }
    public DbSet<Product>? Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasAlternateKey(p => p.Name);
    }
}