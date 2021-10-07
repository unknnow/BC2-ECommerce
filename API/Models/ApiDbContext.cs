using API.Models;
using Microsoft.EntityFrameworkCore;

public class ApiDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Produit> Produits { get; set; }

    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }
}