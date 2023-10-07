﻿using Booking.Entities.Concrete;
using Booking.Entities.DTOs.HotelDTOs;
using CorePackage.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.DataAccess.Abstract
{
    public interface IHotelDAL:  IRepositoryBase<Hotel>
    {
        List<RandomHotelDto> GetRandomProducts();
    }
}
