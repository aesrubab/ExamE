using ConsoleApp1.Entities.Concrate;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Insta.Project.DAL.Configuration;

public class PostConfiguration : IEntityTypeConfiguration<Post>
{
    //cooment ve post yeni 1 postun coxlu commenti ola biler
    public void Configure(EntityTypeBuilder<Post> builder)
    {
        builder.HasMany(p => p.Comments).WithOne();
    }
}
