using BlogASPNET.Data.Mappings;
using BlogASPNET.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogASPNET.Data;
public class DataContext: DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }
    public DbSet<Category> Categories { get; set; }
  public DbSet<Post> Posts { get; set; }
  public DbSet<User> Users { get; set; }
  //protected override void OnConfiguring(DbContextOptionsBuilder options)
  //  => options.UseSqlServer("Server=localhost,1433;Database=blog-modulo-6;User ID=sa;Password=1q2w3e4r@#$;Trusted_Connection=False; TrustServerCertificate=True;");

  protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.ApplyConfiguration(new CategoryMap());
      modelBuilder.ApplyConfiguration(new UserMap());
      modelBuilder.ApplyConfiguration(new PostMap());
    }
}