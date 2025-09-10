namespace Infrastructure.Data.Configurations;

public class FullNameConfiguration : IEntityTypeConfiguration<CustomIdentityUser>
{
    public void Configure(EntityTypeBuilder<CustomIdentityUser> builder)
    {
        builder.OwnsOne(user => user.FullName, fullname =>
        {
            fullname.Property(p => p.FirstName).HasColumnName("FirstName");
            fullname.Property(p => p.LastName).HasColumnName("LastName");
            fullname.Property(p => p.MiddleName).HasColumnName("MiddleName");
        });
    }
}
