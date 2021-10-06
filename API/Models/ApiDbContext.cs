using API.Models;
using Microsoft.EntityFrameworkCore;

public class ApiDbContext : DbContext
{
    public string DbName { get; private set; }

    public DbSet<User> Users { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Produit> Produits { get; set; }

    public ApiDbContext()
    {
        DbName = $"ProjectBC2.db";
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbName}");
}