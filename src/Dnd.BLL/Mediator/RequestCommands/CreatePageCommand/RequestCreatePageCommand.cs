using Dnd.BLL.Mediator.ResponseCommands.CreatePageCommand;
using MediatR;

namespace Dnd.BLL.Mediator.RequestCommands.CreatePageCommand;

public class RequestCreatePageCommand : IRequest<ResponseCreatePageCommand>
{
    public string Name { get; set; }
    public TypeObj Type { get; set; }
    public byte Rare { get; set; }
    public string Source { get; set; }
    public string Text { get; set; }
    public byte[]? MainImage { get; set; }
    public byte[]? Images { get; set; }
    public List<Tag> Tags { get; set; }
}