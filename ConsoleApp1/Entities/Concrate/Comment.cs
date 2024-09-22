
using ConsoleApp1.Entities.Abstract;

namespace ConsoleApp1.Entities.Concrate;

public class Comment:BaseEntity
{
    public string Text { get; set; }
    public string Commentt { get; set; }
    public int LikeCount { get; set; }
    public enum Role
    {
        Admin,
        User
    }

}
