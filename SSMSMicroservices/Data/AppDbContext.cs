using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    DbSet<User> User { get; set; }

    DbSet<Staff> Staff { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
}