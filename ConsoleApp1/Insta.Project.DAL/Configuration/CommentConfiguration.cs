using ConsoleApp1.Entities.Concrate;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Insta.Project.DAL.Configuration;

public class CommentConfiguration : IEntityTypeConfiguration<Comment>
{
    //Commentin commentleri ile yeni 1 commentin coxlu reply ola biler amma hemen reply cox commente aid olammaz
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder.HasMany(c => c.Comments)
            .WithOne();
    }
}

