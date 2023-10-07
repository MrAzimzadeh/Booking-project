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
            CreateMap<HotelUpdateDTO, Hotel>().ReverseMap();
            CreateMap<Hotel, HotelDetailDTO >().ReverseMap();
            CreateMap<Hotel, HotelFeaturedDTO >().ReverseMap();
            CreateMap<Hotel, HotelRecentDTO >().ReverseMap();
            CreateMap<Hotel, HotelFilterDTO >().ReverseMap();


            CreateMap<CategoryCreateDTO, Category>().ReverseMap();
            CreateMap<CategoryUpdateDTO, Category>().ReverseMap();
            CreateMap<Category, CategoryHomeNavbarDTO>().ReverseMap();
            CreateMap<Category, CategoryFeaturedDTO>()
            .ForMember(x => x.HotelCount, o => o.MapFrom(s => s.Hotels.Where(p => p.CategoryId == s.Id).Count()));
            CreateMap<Category, CategoryAdminListDTO>().ReverseMap();




        }
    }
}
