using ConsoleApp1.Entities.Concrate;
using ConsoleApp1.Insta.Project.DAL.Context;

namespace ConsoleApp1.Insta.Project.DAL.Repository.Concrate;

public class UserDetailsRepository : BaseRepository<UserDetail>
{
    public UserDetailsRepository(InstaDbContext context) : base(context)
    {
    }
}
