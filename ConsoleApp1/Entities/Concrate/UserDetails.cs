
using ConsoleApp1.Entities.Abstract;

namespace ConsoleApp1.Entities.Concrate;

public class UserDetail : BaseEntity
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime Birthday { get; set; }
    public Role Role { get; set; }
}

public enum Role
{
    Admin,
    User
}