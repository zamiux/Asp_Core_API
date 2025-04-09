using Microsoft.AspNetCore.Mvc;

namespace CityInfo_API.Controllers
{
    [ApiController]
    // route 3: [Route("api/cities")]
    // route 2: [Route("api/[controller]")]
    public class CitiesController : Controller
    {
        //route 1 with action type :
        //[HttpGet("api/cities")] // url : domain.com/api/cities
        public JsonResult GetCities()
        {
            return new JsonResult(
                new List<Object>
                {
                    new {id = 1, Name ="Tehran"},
                    new {id = 2, Name ="Esfahan"},
                    new {id = 3, Name ="Shiraz"}
                }
            );
        }
    }
}
