using ConsoleApp1.Entities.Concrate;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Insta.Project.DAL.Configuration;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    //user userdetails ile birin bire 
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasOne(u => u.UserDetails)
             .WithOne()
             .HasForeignKey<User>(u => u.Id);
    }
}
