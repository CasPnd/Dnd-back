using AutoMapper;
using Dnd.BLL.Mediator.RequestCommands.CreatePageCommand;
using Dnd.DAL.Models;

namespace Dnd.BLL.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        //Models => Dto

        //Commands => Commands

        //Commands => Dto
        CreateMap<RequestCreatePageCommand, PageDto>().ReverseMap();
    }
}