using CityInfo_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo_API.Controllers
{
    [ApiController]
    // route 3: [Route("api/cities")]
    // route 2: [Route("api/[controller]")]
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
        //route 1 with action type :
        //[HttpGet("api/cities")] // url : domain.com/api/cities

        #region Get Cities 1
        //[HttpGet("api/cities")]
        //public JsonResult GetCities()
        //{
        //    return new JsonResult(
        //        new List<Object>
        //        {
        //            new {id = 1, Name ="Tehran"},
        //            new {id = 2, Name ="Esfahan"},
        //            new {id = 3, Name ="Shiraz"}
        //        }
        //    );
        //}
        #endregion

        #region Get all Cities With Data
        [HttpGet]
        public ActionResult<IEnumerable<CityDTO>> GetCities()
        {
            #region show mode 1: with static code
            //var result = new JsonResult(CitiesDataStore.FillcurrentData.Cities);
            //result.StatusCode = 200;
            #endregion

            #region Show mode 2
            //return new JsonResult(CitiesDataStore.FillcurrentData.Cities);
            #endregion

            #region Show mode 3
            return Ok(CitiesDataStore.FillcurrentData.Cities);
            #endregion
        }
        #endregion

        #region Get Single City
        [HttpGet("{id}")]
        public ActionResult<CityDTO> GetSingleCities(int id)
        {
            #region Show mode 1
            //return new JsonResult(CitiesDataStore.FillcurrentData.Cities.FirstOrDefault(c => c.Id == id));
            #endregion

            #region Show mode 2
            var cityToReturn = CitiesDataStore.FillcurrentData.Cities.FirstOrDefault(c => c.Id == id);

            if (cityToReturn == null)
            {
                return NotFound();
            }
            return Ok(cityToReturn);
            #endregion
        }
        #endregion
    }
}
