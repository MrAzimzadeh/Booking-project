using Booking.Business.Abstract;
using Booking.Entities.Concrete;
using Booking.Entities.DTOs.CategoryDTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;

namespace Booking.MobileApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost]
        public IActionResult CreateCategory([FromBody] CategoryCreateDTO category)
        {

            var a = _categoryService.AddCategory(category);
            if (a.Success) return Ok(a);
            return BadRequest(a);

        }


        [HttpGet("CategoryHotel")]
        public IActionResult GetAllCategory(int? id)
        {

            var a = _categoryService.GetAll(id);
            return Ok(a);


        }
    }
}
