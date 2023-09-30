using Booking.Business.Abstract;
using Booking.DataAccess.Abstract;
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
         public HotelManager(IHotelDAL hotelDAl)
        {
            _hotelDAl = hotelDAl;
        }

        public IResult AddHotel(Hotel hotel)
        {
       
                var result = _hotelDAl.GetAll(x => x.CategoryId == hotel.CategoryId).Count;
                if (result >= 10)
                {
                    return new ErrorResult();
                }
                _hotelDAl.Add(hotel);
                return new SuccessResult();
            }

            public IResult DeleteHotel(Hotel hotel)
        {
            throw new NotImplementedException();
        }

        public IResult UpdateHotel(Hotel hotel)
        {
            throw new NotImplementedException();
        }

    
    }
}
