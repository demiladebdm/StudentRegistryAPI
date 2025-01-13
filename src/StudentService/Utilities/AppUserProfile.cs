using AutoMapper;
using StudentService.DTOs;
using StudentService.Models;

namespace StudentService.Utilities
{
    public class AppUserProfile : Profile
    {
        public AppUserProfile() 
        {
            CreateMap<StudentsDto, Student>().ReverseMap();
        }
    }
}
