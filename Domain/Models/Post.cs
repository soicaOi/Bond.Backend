using Domain.Abstractions;
using Domain.ValueObjects;

namespace Domain.Models;

public class Post : Entity<PostId>
{
    public string Title { get; set; } = default!;
    public string Description { get; set; } = default!;
}
