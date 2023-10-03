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
        IResult DeleteHotel(Hotel hotel);
        IResult UpdateHotel(Hotel hotel);
        IDataResult<List<HotelGetAllDTO>> GetAll();
    }
}
