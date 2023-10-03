using AutoMapper;
using Booking.Business.Abstract;
using Booking.DataAccess.Abstract;
using Booking.DataAccess.Concrete;
using Booking.Entities.Concrete;
using Booking.Entities.DTOs.CategoryDTOs;
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
        private readonly IMapper _mapper;
        public CayegoryManager(ICategoryDAL categoryDAL, IMapper mapper)
        {
            _categoryDAL = categoryDAL;
            _mapper = mapper;
        }

        public IResult AddCategory(CategoryCreateDTO category)
        {
            var map = _mapper.Map<Category>(category);
            _categoryDAL.Add(map);
            return new SuccessResult("Category Added!");
            
                  


        }

        public IResult DeleteCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll(int? id)
        {
            return _categoryDAL.GetAll();
        }

        public IResult UpdateCategory(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
