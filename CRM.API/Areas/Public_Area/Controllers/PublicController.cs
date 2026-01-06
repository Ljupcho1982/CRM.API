using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace CRM.API.Areas.Public_Area.Controllers
{
    [Area("Public_Area")]
    [DisplayName("Public Controller")]


    [Route("api/[area]/[controller]")]
    [ApiController]
    public class PublicController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello from Public Area");
        }
    }
}
