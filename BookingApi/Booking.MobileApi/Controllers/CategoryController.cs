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

        [HttpPost("addcategory")]
        public IActionResult AddCategory([FromBody] CategoryCreateDTO categoryCreateDTO)
        {
            var result = _categoryService.AddCategory(categoryCreateDTO);

            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }
        [HttpPut("updatecategory")]
        public IActionResult UpdateCategory([FromBody] CategoryUpdateDTO categoryUpdateDTO)
        {
            var result = _categoryService.UpdateCategory(categoryUpdateDTO);

            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpGet("homenavbarcategory")]
        public IActionResult CategoryHomeNavbar()
        {
            var result = _categoryService.GetNavbarCategories();
            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }
        [HttpGet("featuredcategory")]
        public IActionResult CategoryFeatured()
        {
            var result = _categoryService.GetFeaturedCategories();
            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }
 
        [HttpGet("admincategories")]
        public IActionResult CategoryAdminList()
        {
            var result = _categoryService.CategoryAdminCategories();
            if (result.Success)
                return Ok(result.Data);

            return BadRequest(result.Data);
        }
   
        [HttpPut("changeStatuscategory/{categoryId}")]
        public IActionResult CategoryChangeStatus(int categoryId)
        {
            var result = _categoryService.CategoryChangeStatus(categoryId);
            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }
   
        [HttpDelete("deletecategory/{categoryId}")]
        public IActionResult CategoryDelete(int categoryId)
        {
            var result = _categoryService.DeleteCategory(categoryId);
            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }

    }
}
