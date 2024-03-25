using AutoMapper;
using WebJobMatchingAPI.DTO;
using WebJobMatchingAPI.Entities;

namespace WebJobMatchingAPI.Mappers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<UsersDTO, Users>().ReverseMap();
            CreateMap<JobsDTO, Jobs>().ReverseMap();
            CreateMap<RolesDTO, Roles>().ReverseMap();
            CreateMap<LoginModel, Users>().ReverseMap();
        }
    }
}
