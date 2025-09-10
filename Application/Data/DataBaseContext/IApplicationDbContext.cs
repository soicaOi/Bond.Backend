namespace Application.Data.DataBaseContext;

public interface IApplicationDbContext
{
    DbSet<CustomIdentityUser> Users { get; set; }
    DbSet<Post> Posts { get; }
}
