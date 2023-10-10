using Booking.Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.DataAccess.Concrete
{
    public class AppDbContext : IdentityDbContext<User>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=SQL5111.site4now.net;Initial Catalog=db_a9fabd_yusif1234;User Id=db_a9fabd_yusif1234_admin;Password=Yusif@123;");
    }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Collection> Collections { get; set; }

        public DbSet<HotelPicture> HotelPictures { get; set; }
        public DbSet<WishList> WishLists { get; set; }





    }
}
