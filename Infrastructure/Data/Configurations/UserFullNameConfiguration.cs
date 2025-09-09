using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations;

public class UserFullNameConfiguration : IEntityTypeConfiguration<CustomIdentityUser>
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
