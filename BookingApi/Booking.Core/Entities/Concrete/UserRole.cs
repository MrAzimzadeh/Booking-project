using System;

namespace CorePackage.Entities.Concrete
{
    public class UserRole
    {
        public int Id { get; set; }
        public int AppUserId { get; set; }
        public AppUser User { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}

