using Microsoft.AspNetCore.Mvc;

namespace AgilePokerBlazor.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SessionController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetRoomID()
        {
            string uniqueRoomUrl = Guid.NewGuid().ToString();
            return Ok(uniqueRoomUrl);
        }
    }
}