using AutoMapper;
using Booking.Business.Abstract;
using Booking.DataAccess.Abstract;
using Booking.DataAccess.Concrete;
using Booking.Entities.Concrete;
using Booking.Entities.DTOs.HotelDTOs;
using CorePackage.Utilities.Results.Abstract;
using CorePackage.Utilities.Results.Concrete.ErrorResults;
using CorePackage.Utilities.Results.Concrete.SuccessResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Business.Concrete
{
    public class HotelManager : IHotelService
    {
        private readonly IHotelDAL _hotelDAl;
        private readonly IMapper _mapper;
        public HotelManager(IHotelDAL hotelDAl, IMapper mapper)
        {
            _hotelDAl = hotelDAl;
            _mapper = mapper;
        }

        public IResult AddHotel(HotelCreteDTO hotel)
        {
            var map = _mapper.Map<Hotel>(hotel);
            _hotelDAl.Add(map);
            return new SuccessResult("Hotel Added!");
        }

        public IDataResult<bool> CheckHotelCount(List<int> hotelIds)
        {
            throw new NotImplementedException();
        }

        public List<HotelGetAllDTO> GetHotelAllById(int? categoryId)
        {
            return _hotelDAl.GetHotelAllById(categoryId);
        }

        public List<HotelFilterByCategoryListDto> GetHotelFilterByCategoryList(int? categoryId, string userId)
        {
            return _hotelDAl.GetHotelFilterByCategoryList(categoryId, userId);
        }

        public IDataResult<List<HotelGetAllDTO>> GetAll()
        {
            var hotel = _hotelDAl.GetAll();
            var map = _mapper.Map<List<HotelGetAllDTO>>(hotel);
            return new SuccessDataResult<List<HotelGetAllDTO>>(map);
        }

        public IResult HotelDelete(int hotelId)
        {
            var product = _hotelDAl.Get(x => x.Id == hotelId);
            _hotelDAl.Delete(product);
            return new SuccessResult("Hotel Deleted!");
        }

        public IDataResult<HotelDetailDTO> HotelDetail(int hotelId)
        {

            var hotel = _hotelDAl.GetHotel(hotelId);
            var map = _mapper.Map<HotelDetailDTO>(hotel);
            map.CategoryName = hotel.Category.CategoryName;
            return new SuccessDataResult<HotelDetailDTO>(map);
        }

        public IDataResult<List<HotelFeaturedDTO>> HotelFeaturedList()
        {
            var hotels = _hotelDAl.GetFeaturedHotels();
            var map = _mapper.Map<List<HotelFeaturedDTO>>(hotels);
            return new SuccessDataResult<List<HotelFeaturedDTO>>(map);
        }

        public IDataResult<List<HotelFilterDTO>> HotelFilterList(int categoryId, int minPrice, int maxPrice, int hotelRoomCount)
        {
            var hotels = _hotelDAl
                .GetAll(x => x.CategoryId == categoryId && x.HotelRoomPrice >= minPrice && x.HotelRoomPrice <= maxPrice && x.HotelRoomCount == hotelRoomCount).ToList();
            var map = _mapper.Map<List<HotelFilterDTO>>(hotels);

            return new SuccessDataResult<List<HotelFilterDTO>>(map);
        }

        public IDataResult<List<HotelRecentDTO>> HotelRecentList()
        {
            var hotels = _hotelDAl.GetRecentHotels();
            var map = _mapper.Map<List<HotelRecentDTO>>(hotels);
            return new SuccessDataResult<List<HotelRecentDTO>>(map);
        }

        public IResult HotelUpdate(HotelUpdateDTO UpdateDTO)
        {
            var product = _hotelDAl.Get(x => x.Id == UpdateDTO.Id);
            var map = _mapper.Map<Hotel>(UpdateDTO);

            product.Status = map.Status;
            product.HotelName = map.HotelName;
            product.HotelRoomPrice = map.HotelRoomPrice;
            product.HotelDescription = map.HotelDescription;
            product.HotelAddress = map.HotelAddress;
            product.CategoryId = map.CategoryId;
            product.IsFeatured = map.IsFeatured;
            product.HotelCity = map.HotelCity;
            product.HotelEmail = map.HotelEmail;
            product.HotelWebsite = map.HotelWebsite;
            product.HotelPhone = map.HotelPhone;
            product.HotelStar = map.HotelStar;
            product.HotelMainImage = map.HotelMainImage;


            _hotelDAl.Update(map);
            return new SuccessResult("Hotel Updated!");
        }
    }
}
