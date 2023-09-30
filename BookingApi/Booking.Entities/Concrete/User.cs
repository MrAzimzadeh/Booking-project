

using Microsoft.AspNetCore.Identity;

namespace Booking.Entities.Concrete
{
    public class User : IdentityUser 
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string PhotoUrl { get; set; }
        public string Address { get; set; }
    }
}
