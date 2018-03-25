using AutoMapper;
using ExampleAutomapper.api.Models;

namespace ExampleAutomapper.api.AppStart
{
    public class UserMapperProfile : Profile, IUserMapper
    {
        public UserMapperProfile()
        {
            CreateMap<User,UserMap>()
                .ForMember(
                    dest => dest.Name,
                    opt => opt.MapFrom(src => GetFullName(src.Title,src.Firstname,src.Lastname)));
        }
        public string GetFullName(string Title, string Firstname, string Lastname)
        {
            return $"{Title} {Firstname} {Lastname}";
        }
    }
}