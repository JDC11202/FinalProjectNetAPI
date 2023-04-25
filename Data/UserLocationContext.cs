using Microsoft.EntityFrameworkCore;

namespace FinalProjectNetAPI.Data;

public class UserLocationContext : DbContext
{
    public UserLocationContext(DbContextOptions<UserLocationContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<UserLocationInfo>().HasData
            (new UserLocationInfo { Id = 1, })
    }

    public DbSet<UserLocationInfo> Location { get; set; }
}