using CorePackage.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.Entities.Concrete
{
    public class HotelPicture : IEntity
    {
        public int Id { get; set; }
        public string PicturePath { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }



    }
}