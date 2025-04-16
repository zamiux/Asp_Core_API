using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace CityInfo_API.Controllers
{
    [Route("api/files")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetFiles(string FileId) {
            var PassToFile = "PL-SQL-CheatSheet-master.zip"; // address file with filename

            // check file is exist
            if (!System.IO.File.Exists.(PassToFile))
            {
                return NotFound();
            }
        }
    }
}
