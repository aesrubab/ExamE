using ConsoleApp1.Entities.Concrate;

namespace ConsoleApp1.Insta.Project.DAL.Repository.Abstract;

public interface IUnitOfWork
{
    IRepository<Post> Posts { get; }
    IRepository<Comment> Comments { get; }
    IRepository<User> Users { get; }
    IRepository<UserDetail> UserDetails { get; }

    //Deyisikliklerin tesdiqlenmesi ucundu asagidki
    int Complete();
}
