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
        optionsBuilder.UseSqlServer("Server=127.0.0.1,1433;Database= BootingDb; User Id=sa; Password=Password@12345;TrustServerCertificate=True;");
    }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
    }
}
