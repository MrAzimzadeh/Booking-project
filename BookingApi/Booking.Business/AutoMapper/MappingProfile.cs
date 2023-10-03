using AutoMapper;
using Booking.Entities.Concrete;
using Booking.Entities.DTOs.CategoryDTOs;
using Booking.Entities.DTOs.HotelDTOs;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<HotelCreteDTO,Hotel>().ReverseMap();
            CreateMap<HotelGetAllDTO,Hotel>().ReverseMap();
            CreateMap<CategoryCreateDTO, Category>().ReverseMap();




        }
    }
}
