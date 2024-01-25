using AutoMapper;
using Dnd.BLL.Mediator.RequestCommands.CreatePageCommand;
using Dnd.DAL.Models;

namespace Dnd.BLL.Mapping.Extensions;

public static class CreatePageToPageDto
{
    public static PageDto MapPage(this IMapper mapper, RequestCreatePageCommand pageCommand)
    {
        var result = new PageDto()
        {
            Name = pageCommand.Name,
            Type = pageCommand.Type.Name,
            Rare = pageCommand.Rare,
            Source = pageCommand.Source,
            Text = pageCommand.Text,
            MainImage = pageCommand.MainImage,
            Images = pageCommand.Images,
            Tags = pageCommand.Tags.Select(t => t.Name).ToList()
        };

        return result;
    }
}