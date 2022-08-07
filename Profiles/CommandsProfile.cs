
using AutoMapper;
using DOTNET_REST_API.DTOs;
using DOTNET_REST_API.Models;


// Mapping Command objects so Profile attribute isn't shown on client side
namespace DOTNET_REST_API.Profiles
{
    public class CommandsProfile: Profile
    {
        // Source -> Target
        public CommandsProfile()
        {
            CreateMap<Command, CommandReadDto>();
            // commandCreateDto map to a Command obj
            CreateMap<CommandCreateDto, Command>();
            CreateMap<CommandUpdateDto, Command>();  
            CreateMap<Command, CommandUpdateDto>();

        }
    }
}