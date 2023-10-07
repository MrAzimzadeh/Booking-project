using Booking.Entities.Concrete;
using Booking.Entities.DTOs.HotelDTOs;
using CorePackage.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Business.Abstract
{
   public interface IHotelService
    {
        IResult AddHotel(HotelCreteDTO hotel);
        IDataResult<List<HotelGetAllDTO>> GetAll();
        IResult HotelUpdate(HotelUpdateDTO UpdateDTO);
        IResult HotelDelete(int hotelId);
        IDataResult<HotelDetailDTO> HotelDetail(int hotelId);
        IDataResult<List<HotelFeaturedDTO>> HotelFeaturedList();
        IDataResult<List<HotelRecentDTO>> HotelRecentList();
        IDataResult<List<HotelFilterDTO>> HotelFilterList(int categoryId, int minPrice, int maxPrice, int hotelRoomCount);
        IDataResult<bool> CheckHotelCount(List<int> hotelIds);
    }
}
