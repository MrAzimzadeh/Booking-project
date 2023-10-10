using Booking.DataAccess.Abstract;
using Booking.Entities.Concrete;
using CorePackage.DataAccess.EntityFramework;
using Microsoft.EntityFrameworkCore;
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

        public List<HotelGetAllDTO> GetHotelAllById(int? categoryId)
        {
            using var context = new AppDbContext();
            if (categoryId == null)
            {
                return context.Hotels.Include(x => x.Category)
                    .Select(x => new HotelGetAllDTO
                    {
                        CategoryName = x.Category.CategoryName,
                        CategoryId = x.CategoryId,
                        HotelAddress = x.HotelAddress,
                        HotelCity = x.HotelCity,
                        HotelDescription = x.HotelDescription,
                        HotelEmail = x.HotelEmail,
                        HotelMainImage = x.HotelMainImage,
                        HotelPhone = x.HotelPhone,
                        HotelName = x.HotelName,
                        HotelRoomCapacity = x.HotelRoomCapacity,
                        HotelRoomCount = x.HotelRoomCount,
                        HotelRoomPrice = x.HotelRoomPrice,
                        HotelWebsite = x.HotelWebsite,
                        Id = x.Id,
                        Latitude = x.Latitude,
                        Longitude = x.Longitude,
                    }).ToList();

            }
            else
            {
                return context.Hotels.Include(x => x.Category).Where(x => x.CategoryId == categoryId)
                    .Select(x => new HotelGetAllDTO
                    {
                        CategoryName = x.Category.CategoryName,
                        CategoryId = x.CategoryId,
                        HotelAddress = x.HotelAddress,
                        HotelCity = x.HotelCity,
                        HotelDescription = x.HotelDescription,
                        HotelEmail = x.HotelEmail,
                        HotelMainImage = x.HotelMainImage,
                        HotelPhone = x.HotelPhone,
                        HotelName = x.HotelName,
                        HotelRoomCapacity = x.HotelRoomCapacity,
                        HotelRoomCount = x.HotelRoomCount,
                        HotelRoomPrice = x.HotelRoomPrice,
                        HotelWebsite = x.HotelWebsite,
                        Id = x.Id,
                        Latitude = x.Latitude,
                        Longitude = x.Longitude,
                    }).ToList();
            }

        }

        public List<HotelFilterByCategoryListDto> GetHotelFilterByCategoryList(int? categoryId, string userId)
        {
            using var context = new AppDbContext();


            if (categoryId == null)
            {
                var result = new List<HotelFilterByCategoryListDto>();
                foreach (var res in context.Hotels.Include(z => z.Category).Include(z => z.WishList).ToList())
                {
                    var a = new HotelFilterByCategoryListDto();
                    a.CategoryId = res.Id;
                    a.CategoryName = res.Category.CategoryName;
                    a.Id = res.Id;
                    if (context.WishLists.FirstOrDefault(z => z.UserId == userId && z.HotelId == a.Id) == null)
                    {
                        a.IsLike = false;
                    }
                    else
                    {
                        a.IsLike = true;
                    }
                 

                    result.Add(a);
                }
                return result;
            }
            else
            {
                return context.Hotels.Include(x => x.Category).Where(x => x.CategoryId == categoryId)
                    .Select(x => new HotelFilterByCategoryListDto
                    {
                        CategoryName = x.Category.CategoryName,
                        CategoryId = x.CategoryId,
                        HotelAddress = x.HotelAddress,
                        HotelCity = x.HotelCity,
                        HotelDescription = x.HotelDescription,
                        HotelEmail = x.HotelEmail,
                        HotelMainImage = x.HotelMainImage,
                        HotelPhone = x.HotelPhone,
                        HotelName = x.HotelName,
                        HotelRoomCapacity = x.HotelRoomCapacity,
                        HotelRoomCount = x.HotelRoomCount,
                        HotelRoomPrice = x.HotelRoomPrice,
                        HotelWebsite = x.HotelWebsite,
                        Id = x.Id,
                        Latitude = x.Latitude,
                        Longitude = x.Longitude,
                    }).ToList();
            }

        }
    }
}
