using Booking.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;

namespace Booking.MobileApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpPost("categorypost")]
        public IActionResult Category([FromBody] Hotel postShareDTO)
        {
            var _bearer_token = Request.Headers[HeaderNames.Authorization].ToString().Replace("Bearer ", "");
            var handler = new JwtSecurityTokenHandler();
            var jwtSecurityToken = handler.ReadJwtToken(_bearer_token);
            var userId = jwtSecurityToken.Claims.FirstOrDefault(x => x.Type == "nameid").Value;
            //int convertingUserId = Convert.ToInt32(userId);
            int.TryParse(userId, out int convertingUserId);
            var result = _postService.AddPost(convertingUserId, postShareDTO);
            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }
    }
}
