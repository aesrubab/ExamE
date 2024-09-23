using ConsoleApp1.Entities.Abstract;

namespace ConsoleApp1.Entities.Concrate;

public class User:BaseEntity
{
    public UserDetail UserDetails { get; set; }
}
    