using AutoMapper;
using DomainLayer.Models.BasketModels;
using Shared.DTOS.BasketDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.MappingProfiles
{
    public class BasketMappingProfiles : Profile
    {
        public BasketMappingProfiles()
        {
            //CreateMap<Source, Destination>();
            CreateMap<CustomerBasket,BasketDto>().ReverseMap();
            CreateMap<BasketItem,BasketItemDto>().ReverseMap();
        }
    }
}
