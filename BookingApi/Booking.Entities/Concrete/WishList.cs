using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.Entities.Concrete
{
    public class WishList
    {
        public int Id { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
        public string UserId { get; set; }
        public DateTime DateTime { get; set; }
        

    }
}