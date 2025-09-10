namespace Application.Posts.Commands.CreatePost;

public record CreatePostCommand(CreatePostDto dto) : ICommand<CreatePostResult>;

public record CreatePostResult(string Detail);