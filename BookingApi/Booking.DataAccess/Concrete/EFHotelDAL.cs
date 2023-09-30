using Booking.DataAccess.Abstract;
using Booking.Entities.Concrete;
using CorePackage.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Booking.DataAccess.Concrete
{
     public class EFHotelDAL : EfRepositoryBase< Hotel, AppDbContext>,IHotelDAL
    {
    }
}
  