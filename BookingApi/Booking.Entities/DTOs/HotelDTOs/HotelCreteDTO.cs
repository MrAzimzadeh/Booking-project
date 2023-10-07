using Booking.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Entities.DTOs.HotelDTOs
{
    public class HotelCreteDTO
    {
        public string HotelName { get; set; }
        public string HotelAddress { get; set; }
        public string HotelCity { get; set; }
        public string HotelPhone { get; set; }
        public string HotelEmail { get; set; }
        public string HotelWebsite { get; set; }
        public string HotelDescription { get; set; }
        public string HotelMainImage { get; set; }
        public int HotelRoomCount { get; set; }
        public int HotelRoomCapacity { get; set; }
        public decimal HotelRoomPrice { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public int CategoryId { get; set; }
        public string UserId { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsFeatured { get; set; }


    }
}
