using Booking.Entities.Concrete;
using Booking.Entities.DTOs.CategoryDTOs;
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
        IResult AddCategory(CategoryCreateDTO categoryCreateDTO);
        IResult UpdateCategory(CategoryUpdateDTO categoryUpdateDTO);
        IResult DeleteCategory(int categoryId);
        IResult CategoryChangeStatus(int categoryId);
        IDataResult<List<CategoryAdminListDTO>> CategoryAdminCategories();
        IDataResult<List<CategoryHomeNavbarDTO>> GetNavbarCategories();
        IDataResult<List<CategoryFeaturedDTO>> GetFeaturedCategories();
    }
}
