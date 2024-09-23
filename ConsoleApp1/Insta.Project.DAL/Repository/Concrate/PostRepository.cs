using ConsoleApp1.Entities.Concrate;
using ConsoleApp1.Insta.Project.DAL.Context;

namespace ConsoleApp1.Insta.Project.DAL.Repository.Concrate;

public class PostRepository : BaseRepository<Post>
{
    public PostRepository(InstaDbContext context) : base(context)
    {
    }
}
