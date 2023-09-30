using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.Entities.Concrete
{
    public class Hotel
    {
        public int Id { get; set; }
        public string HotelName { get; set; }
        public string HotelAddress { get; set; }
        public string HotelCity { get; set; }
        public string HotelPhone { get; set; }
        public string HotelEmail { get; set; }
        public string HotelWebsite { get; set; }
        public string HotelDescription { get; set; }
        public string HotelMainImage { get; set; }
        public decimal HotelStar { get; set; }
        public int HotelRoomCount { get; set; }
        public int HotelRoomCapacity { get; set; }
        public decimal HotelRoomPrice { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public decimal Review { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}