using AutoMapper;
using RYTUserManagementService.Dto;

namespace RYTUserManagementService.Models
{
    public class Mappings : Profile
    {
        public Mappings()
        {
            CreateMap<Student, StudentsDto>();
        }
    }
}
