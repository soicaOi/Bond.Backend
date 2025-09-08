using Domain.ValueObjects;
using Microsoft.AspNetCore.Identity;

namespace Domain.Security;

public class CustomIdentityUser : IdentityUser
{
    public FullName Fullname { get; set; } = default!;
}
