using CityInfo_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo_API.Controllers
{
    // url: /api/cities/2/pointofinterest
    [Route("api/cities/{cityId}/pointofinterest")]
    [ApiController]
    public class PointOfInterestController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<PointOfOnterestDTO>> GetListPointsOfInterest(int cityId)
        {
            var city_data = CitiesDataStore.FillcurrentData.Cities
                .FirstOrDefault(c => c.Id == cityId);

            if (city_data == null)
            {
                return NotFound();
            }

            return Ok(city_data.NumberOfPointInterest);
        }

        // url: /api/cities/2/pointofinterest/1

        [HttpGet("{pointOfInterestId}")]
        public ActionResult<PointOfOnterestDTO> GetPointOfInterest(int cityId,int pointOfInterestId)
        {
            var city_data = CitiesDataStore.FillcurrentData.Cities
                .FirstOrDefault(c => c.Id == cityId);

            if (city_data == null)
            {
                return NotFound();
            }
            
            var points = city_data.pointOfOnterestDTOs
                .FirstOrDefault(c => c.Id == pointOfInterestId);

            if (points == null)
            {
                return NotFound();
            }

            return Ok(points);
        }
    }
}
