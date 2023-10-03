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

        public IResult DeleteHotel(Hotel hotel)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<HotelGetAllDTO>> GetAll()
        {
            var hotel = _hotelDAl.GetAll();
            var map = _mapper.Map<List<HotelGetAllDTO>>(hotel);
            return new SuccessDataResult<List<HotelGetAllDTO>>(map);
        }

        public IResult UpdateHotel(Hotel hotel)
        {
            throw new NotImplementedException();
        }


    }
}
