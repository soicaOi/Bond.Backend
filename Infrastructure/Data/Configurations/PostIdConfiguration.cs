namespace Infrastructure.Data.Configurations;

public class PostIdConfiguration : IEntityTypeConfiguration<Post>
{
    public void Configure(EntityTypeBuilder<Post> builder)
    {
        builder.Property(post => post.Id)
            .HasConversion(
                id => id.Value,
                value => PostId.Of(value)
            );
    }
}
