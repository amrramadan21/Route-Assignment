using AutoMapper;
using Demo.BLL.DTOs.EmployeeDTOs;
using Demo.DAL.Models.EmployeeModel;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.MappingProfiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            //CreateMap<Employee,EmployeeDto>();//From Employee To Employee Dto
            //CreateMap<EmployeeDto, Employee>();//From Employee Dto To Employee 

            CreateMap<Employee, EmployeeDto>()
                .ForMember(dest => dest.EmpGender,Options=> Options.MapFrom(src => src.Gender))
                .ForMember(dest => dest.EmpType,Options=> Options.MapFrom(src => src.EmployeeType))
                .ReverseMap();


            CreateMap<Employee, EmployeeDetailsDto>()
                .ForMember(dest => dest.Gender, Options => Options.MapFrom(src => src.Gender))
                .ForMember(dest => dest.EmployeeType,Options=> Options.MapFrom(src => src.EmployeeType))
                .ForMember(dest => dest.HiringDate, Options => Options.MapFrom(src => DateOnly.FromDateTime(src.HiringDate)))
                .ReverseMap();

            CreateMap<CreateEmployeeDtos, Employee>()
                .ForMember(dest => dest.HiringDate, Options => Options.MapFrom(src => src.HiringDate.ToDateTime(new TimeOnly())))
                .ReverseMap();

            CreateMap<UpdateEmployeeDto, Employee>()
                .ForMember(dest => dest.HiringDate, Options => Options.MapFrom(src => src.HiringDate.ToDateTime(new TimeOnly())))
                .ReverseMap();





        }
    }
}
