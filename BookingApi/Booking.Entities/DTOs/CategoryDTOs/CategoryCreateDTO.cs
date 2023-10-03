using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Entities.DTOs.CategoryDTOs
{
     public class CategoryCreateDTO
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string CategoryPath { get; set; }
    }
}
