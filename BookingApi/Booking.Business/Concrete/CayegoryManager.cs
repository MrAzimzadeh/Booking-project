using Booking.Business.Abstract;
using Booking.DataAccess.Abstract;
using Booking.Entities.Concrete;
using CorePackage.Utilities.Results.Abstract;
using CorePackage.Utilities.Results.Concrete.ErrorResults;
using CorePackage.Utilities.Results.Concrete.SuccessResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Business.Concrete
{
    public class CayegoryManager : ICategoryService
    {
       private readonly ICategoryDAL _categoryDAL;

        public CayegoryManager(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

        public IResult AddCategory(Category category)
        {
            try
            {
                _categoryDAL.Add(category);
                return new SuccessResult();
            }
            catch (Exception)
            {
                return new ErrorResult();
            }

           
        }

        public IResult DeleteCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public IResult UpdateCategory(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
