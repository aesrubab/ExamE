using ConsoleApp1.Entities.Concrate;
using ConsoleApp1.Insta.Project.DAL.Context;
using ConsoleApp1.Insta.Project.DAL.Repository.Abstract;

namespace ConsoleApp1.Insta.Project.DAL.Repository.Concrate;

public class UnitOfWork : IUnitOfWork
{
    private readonly InstaDbContext _context;
    public IRepository<User> Users { get; set; }
    public IRepository<Comment> Comments { get; set; }
    public IRepository<Post> Posts { get; set; }
    public IRepository<UserDetail> UserDetails { get; set; }

    public UnitOfWork(InstaDbContext context)
    {
        //gonderdiyimiz kontekse aid olsun deye
        _context = context;
        Posts = new BaseRepository<Post>(_context);
        Comments = new BaseRepository<Comment>(_context);
        Users = new BaseRepository<User>(_context);
        UserDetails = new BaseRepository<UserDetail>(_context);

    }

    public int Complete()
    {
        return _context.SaveChanges();
    }

    //konteksi baglamag ucun
    public void Dispose()
    {
        _context.Dispose();
    }
}
