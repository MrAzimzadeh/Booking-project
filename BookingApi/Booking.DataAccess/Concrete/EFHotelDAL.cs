using Booking.DataAccess.Abstract;
using Booking.Entities.Concrete;
using CorePackage.DataAccess.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Booking.DataAccess.Concrete
{
     public class EFHotelDAL : EfRepositoryBase<Hotel, AppDbContext>,IHotelDAL
    {
        public List<Hotel> GetFeaturedHotels()
        {
            using var context = new AppDbContext();
            var hotels = context.Hotels
                .Where(x => x.IsFeatured == true && x.Status == true)
                .OrderByDescending(x => x.CreatedDate).Take(8).ToList();
            return hotels;
        }

        public Hotel GetHotel(int id)
        {
            using var context = new AppDbContext();
            var product = context.Hotels
                .Include(x => x.Category).SingleOrDefault(p => p.Id == id);

            return product;
        }
        public List<Hotel> GetRecentHotels()
        {
            using var context = new AppDbContext();
            var hotels = context.Hotels
                .Where(x => x.Status == true)
                .OrderByDescending(x => x.CreatedDate).Take(8).ToList();
            return hotels;
        }

    }
}
  