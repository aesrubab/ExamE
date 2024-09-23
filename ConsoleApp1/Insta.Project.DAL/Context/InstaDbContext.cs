using ConsoleApp1.Entities.Concrate;
using ConsoleApp1.Insta.Project.DAL.Configuration;
using Microsoft.EntityFrameworkCore;


namespace ConsoleApp1.Insta.Project.DAL.Context;

//DbContext yazaraq VB ile elaqe qururuq
public class InstaDbContext : DbContext
{
    //Program cs de default ctor ist edirik deye bos ctor yaziriq burada
    public InstaDbContext()
    {
    }

    //DbContext sinifini konfiqurasiya etmekcun asagidakini yaziriq
    public InstaDbContext(DbContextOptions<InstaDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<UserDetail> UserDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=WINDOWS-2P363HE;Initial Catalog=SocialMedia;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new PostConfiguration());
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new CommentConfiguration());
    }

}
