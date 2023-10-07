using Booking.Entities.Concrete;
using Booking.Entities.DTOs.CategoryDTOs;
using Booking.Entities.DTOs.HotelDTOs;
using CorePackage.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Business.Abstract
{
    public interface ICategoryService
    {
        IResult AddCategory(CategoryCreateDTO category);
        IResult DeleteCategory(Category category);
        IResult UpdateCategory(Category category);
        List<Category> GetAll(int ? id );
    }
}
