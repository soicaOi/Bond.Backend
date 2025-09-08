using Domain.Exceptions;

namespace Domain.ValueObjects;

public record PostId
{
    public Guid Value { get; } = default!;

    private PostId(Guid value)
    {
        Value = value;
    }

    public static PostId Of(Guid value)
    {
        if (value == Guid.Empty)
        {
            throw new DomainException("PostId не может быть пустым");
        }

        return new PostId(value);
    }
}
