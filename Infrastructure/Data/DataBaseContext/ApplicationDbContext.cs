using Application.Data.DataBaseContext;
using Domain.Security;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Infrastructure.Data.DataBaseContext;

public class ApplicationDbContext : IdentityDbContext<CustomIdentityUser>, IApplicationDbContext
{
}
