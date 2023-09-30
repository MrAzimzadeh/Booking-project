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
        IResult Add(HotelCreteDTO hotelCreteDTO);
        IResult Delete();
        IResult Update();
    }
}
