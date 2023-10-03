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

    }
}