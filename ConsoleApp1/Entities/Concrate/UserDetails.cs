
using ConsoleApp1.Entities.Abstract;

namespace ConsoleApp1.Entities.Concrate;

public class UserDetails:BaseEntity
{
    public string Name { get; set; }
    public string SurName { get; set; }
    public string Birthday { get; set; }

}
