using Microsoft.EntityFrameworkCore;
using week8.Pages;

public class FeedBackDBContext : DbContext
{
    public FeedBackDBContext(DbContextOptions<FeedBackDBContext> options) : base(options)
    {
    }

    public DbSet<User> User { get; set; }

}