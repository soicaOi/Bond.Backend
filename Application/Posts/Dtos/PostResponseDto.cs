namespace Application.Posts.Dtos;

public record PostResponseDto(
    string Title,
    string Description,
    DateTimeOffset CreateAt,
    DateTimeOffset? UpdateAt
);