public class FinalProjectNetAPIDBContext : DbContext {
   public MyWebAPIDBContext(DbContextOptions<MyWebAPIDBContext> options) 

: base(options) 

{ 

} 
public DbSet<UserInfo> TeamMembers { get; set; } 

public DbSet<UserLocationInfo> UserLocation { get; set; } 

public DbSet<UserHobbies> Hobbies { get; set; } 

public DbSet<UserFoods> Food { get; set; } 

public DbSet<UserMusic> Music { get; set; } 

} 