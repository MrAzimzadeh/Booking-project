using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Booking.Business.Abstract;
using Booking.Entities.Concrete;
using Booking.Entities.DTOs.HotelDTOs;
using Microsoft.AspNetCore.Mvc;

namespace Booking.MobileApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IHotelService _hotelService;

        public ProductController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }

        [HttpPost("create")]
        public IActionResult CreateHotel([FromBody]HotelCreteDTO hotel)
        {
            var a = _hotelService.AddHotel(hotel);
            if (a.Success)
            {
                return Ok(a);
            }
            
            return BadRequest(a);
        }

        [HttpGet("PraductHotel")]
        public IActionResult GetAllCategory()
        {

            var a =_hotelService.GetAll();
            return Ok(a);


        }
        [HttpPut("updatedhotel")]
        public IActionResult UpdatedHotel([FromBody] HotelUpdateDTO UpdateDTO)
        {
            var result = _hotelService.HotelUpdate(UpdateDTO);

            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpGet("hoteldetail/{hotelId}")]
        public IActionResult HotelDetail(int hotelId)
        {
            var result = _hotelService.HotelDetail(hotelId);

            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }
        [HttpGet("featuredhotels")]
        public IActionResult HotelFeatured()
        {
            var hotel = _hotelService.HotelFeaturedList();
            if (hotel.Success)
                return Ok(hotel);
            return BadRequest(hotel);
        }

        [HttpGet("recenthotels")]
        public IActionResult HotelRecent()
        {
            var product = _hotelService.HotelRecentList();
            if (product.Success)
                return Ok(product);
            return BadRequest(product);
        }
      
        [HttpGet("filterhotels")]
        public IActionResult HotelFilter([FromQuery] int categoryId, [FromQuery] int minPrice, [FromQuery] int maxPrice , [FromQuery] int hotelRoomCount)
        {
            var hotel = _hotelService.HotelFilterList(categoryId, minPrice, maxPrice, hotelRoomCount);
            if (hotel.Success)
                return Ok(hotel);
            return BadRequest(hotel);
        }
       
        [HttpDelete("deletehotel/{hotelId}")]
        public IActionResult Delete(int hotelId)
        {
            var result = _hotelService.HotelDelete(hotelId);
            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }

    }
}