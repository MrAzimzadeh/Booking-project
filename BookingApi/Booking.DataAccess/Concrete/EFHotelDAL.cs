using Booking.DataAccess.Abstract;
using Booking.Entities.Concrete;
using CorePackage.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Booking.Entities.DTOs.HotelDTOs;

namespace Booking.DataAccess.Concrete
{
    public class EFHotelDAL : EfRepositoryBase<Hotel, AppDbContext>, IHotelDAL
    {
        public List<RandomHotelDto> GetRandomProducts()
        {
            using var context = new AppDbContext();
            var result = context.Hotels.OrderByDescending(x => x.Id).Select(x => new RandomHotelDto
            {
                HotelName = x.HotelName,
                HotelAddress = x.HotelAddress,
                Reiting = x.Review,
                Id = x.Id,
                PhotoUrl = x.HotelMainImage
            }).ToList();
            return result;
        }
    }
}
