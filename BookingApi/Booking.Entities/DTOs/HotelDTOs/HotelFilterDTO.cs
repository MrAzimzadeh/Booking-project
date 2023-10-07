using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Entities.DTOs.HotelDTOs
{
    public class HotelFilterDTO
    {
        public int Id { get; set; }
        public string HotelName { get; set; }
        public string HotelDescription { get; set; }
        public string HotelMainImage { get; set; }

    }
}
