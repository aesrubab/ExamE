
using ConsoleApp1.Entities.Abstract;

namespace ConsoleApp1.Entities.Concrate;

public class Post:BaseEntity
{
    public string Text { get; set; }
    public string Comment { get; set; }
    public int LikeCount { get; set; }
}
