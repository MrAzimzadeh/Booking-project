using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Entities.DTOs.HotelDTOs
{
    public class RandomHotelDto
    {
        public int Id { get; set; }
        public string HotelName { get; set; }
        public string HotelAddress { get; set; }

        public decimal Reiting  { get; set; }
        public string PhotoUrl { get; set; }
    }
}
