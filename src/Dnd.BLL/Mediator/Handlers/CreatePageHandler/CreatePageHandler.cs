using AutoMapper;
using Dnd.BLL.Mapping.Extensions;
using Dnd.BLL.Mediator.RequestCommands.CreatePageCommand;
using Dnd.BLL.Mediator.ResponseCommands.CreatePageCommand;
using Dnd.DAL.Repositories.Interfaces;
using MediatR;

namespace Dnd.BLL.Mediator.Handlers.CreatePageHandler;

public class CreatePageHandler : IRequestHandler<RequestCreatePageCommand, ResponseCreatePageCommand>
{
    public IPageRepository _pageRepository { get; set; }
    public IMapper _mapper { get; set; }

    public CreatePageHandler(IPageRepository pageRepository, IMapper mapper)
    {
        _pageRepository = pageRepository;
        _mapper = mapper;
    }

    public async Task<ResponseCreatePageCommand> Handle(RequestCreatePageCommand request,
        CancellationToken cancellationToken)
    {
        var page = _mapper.MapPage(request);
        await _pageRepository.CreateAsync(page);

        return new ResponseCreatePageCommand();
    }
}