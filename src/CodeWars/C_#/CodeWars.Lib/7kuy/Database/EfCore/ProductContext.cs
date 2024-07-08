using Microsoft.EntityFrameworkCore;

public class ProductContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public ProductContext()
    {
        Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=dev;Password=dev111");
    }
}