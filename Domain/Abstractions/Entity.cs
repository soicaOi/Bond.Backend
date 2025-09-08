namespace Domain.Abstractions;

public abstract class Entity<T> : IEntity<T>
{
    public T Id { get; set; } = default!;

    public DateTimeOffset CreateAt { get; set; } = default!;
    public DateTimeOffset? UpdateAt { get; set; } = default!;
    public bool IsDeleted { get; set; } = default!;
    public DateTimeOffset? DeletedAt { get; set; } = default!;
}
