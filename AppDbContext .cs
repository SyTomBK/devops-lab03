using Microsoft.EntityFrameworkCore;

namespace lab03;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }
}
public class User
{
    public Guid Id { get; set; }
    public string Username { get; set; } = default!;
}