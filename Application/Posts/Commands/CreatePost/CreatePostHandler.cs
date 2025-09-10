using Application.Data.DataBaseContext;

namespace Application.Posts.Commands.CreatePost;

public class CreatePostHandler(IApplicationDbContext dbContext)
    : ICommandHandler<CreatePostCommand, CreatePostResult>
{
    public async Task<CreatePostResult> Handle(CreatePostCommand request, CancellationToken cancellationToken)
    {
        

        return new CreatePostResult("Успешное добавление");
    }
}
