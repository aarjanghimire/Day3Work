using AutoMapper;
using Day3Work.DTOs.UsersDTOs;
using Day3Work.Models;

namespace Day3Work.Helpers
{
    public class MapperProfiles : Profile
    {
        //Install-Package AutoMapper
        public MapperProfiles() {
            CreateMap<Users, GetUsersDTO>();
        }
    }
}
