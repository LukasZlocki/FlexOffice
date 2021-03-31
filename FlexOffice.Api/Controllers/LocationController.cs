using FlexOffice.Api.Dto;
using FlexOffice.Api.Serialization;
using FlexOffice.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FlexOffice.Api.Controllers
{
    public class LocationController : ControllerBase
    {
        private readonly ILogger<LocationController> _logger;
        private readonly ILocationService _locationService; 

        public LocationController(ILocationService locationService, ILogger<LocationController> logger)
        {
            _locationService = locationService;
            _logger = logger;
        }

        [HttpGet("api/location")]
        public ActionResult GetAllLocations()
        {
            _logger.LogInformation("Get all location");
            var service = _locationService.GetAllLocations();
            var locationsMapper = LocationMapper.SerializeListLocationToDTO(service);
            return Ok(locationsMapper);
        }

        [HttpGet("api/location/{id}")]
        public ActionResult GetLocation(int id)
        {
            var service = _locationService.GetLocationById(id);
            var locationMapper = LocationMapper.SerializeToLocationDTO(service);
            return Ok(locationMapper);
        }

        // ToDo : code serialization DTO
        [HttpPost("api/location")]
        public ActionResult CreateLocation ([FromBody] LocationCreateDTO locationDTO )
        {
            var location = LocationMapper.SerializeCreateLocation(locationDTO);
            var resonse = _locationService.CreateLocation(location);
            return Ok(resonse);
        }

        [HttpDelete("api/location/{id}")]
        public ActionResult DeleteLocation(int id)
        {
            var response = _locationService.DeleteLocation(id);
            return Ok(response);
        }
        
    }
}