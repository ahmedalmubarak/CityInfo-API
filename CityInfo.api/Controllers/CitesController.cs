using CityInfo.api.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.api.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<CityDto> >GetCites()
        {
            var citiesToBeReturned = CitiesDataStore.Current.Cities;
            return Ok(citiesToBeReturned);
        }


        [HttpGet("{id}")]
        public ActionResult<CityDto> GetCity(int id)
        {
            //Find city
            var cityToReturned = CitiesDataStore.Current.Cities.FirstOrDefault(city => city.Id == id);
            if(cityToReturned == null)
            {
                return NotFound();
            }
            return  Ok(cityToReturned);
        
        }
    }
}
