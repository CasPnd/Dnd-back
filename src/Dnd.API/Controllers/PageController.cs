using Dnd.BLL.Mediator.RequestCommands.CreatePageCommand;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Dnd.API.Controllers;

[ApiController]
[Route("[controller]")]
public class PageController : ControllerBase
{
    public IMediator _mediator { get; set; }

    public PageController(IMediator mediator)
    {
        _mediator = mediator;
    }

    /// <summary>
    /// Создает страницу
    /// </summary>
    /// <param name="requestCreatePageCommand"></param>
    [HttpPost]
    public void CreatePage(RequestCreatePageCommand requestCreatePageCommand)
    {
        _mediator.Send(requestCreatePageCommand);
    }
}