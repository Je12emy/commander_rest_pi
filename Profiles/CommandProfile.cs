using AutoMapper;
using net_rest.Dtos;
using net_rest.Models;

namespace net_rest.Profiles
{
    class CommandProfile : Profile
    {
        public CommandProfile()
        {
            // source --> target
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
            CreateMap<CommandUpdateDto, Command>();
        }
    }
}
