using FlexOffice.Data.Models;
using FlexOffice.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FlexOffice.Api.Controllers
{
    [ApiController]
    public class DeskController : ControllerBase
    {
        private readonly ILogger<DeskController> _logger;
        private readonly IDeskService _deskService;

        public DeskController(ILogger<DeskController> logger, IDeskService deskService)
        {
            _logger = logger;
            _deskService = deskService;
        }

        [HttpGet("api/desk")]
        public ActionResult GetAllDesks()
        {
            _logger.LogInformation("Get all desks.");
            var desks = _deskService.GetAllDesks();
            return Ok(desks);
        }

        [HttpGet("api/desk/{id}")]
        public ActionResult GetDeskById(int id)
        {
            _logger.LogInformation("Get desk by id.");
            var desk = _deskService.GetDeskById(id);
            return Ok(desk);
        }

        [HttpGet("api/desk/location/{id}")]
        public ActionResult GetDesksByLocation(int locationId)
        {
            _logger.LogInformation("Get desks by location.");
            var desks = _deskService.GetDesksByLocation(locationId);
            return Ok(desks);
        }
        
        // ToDo : Zastosowac Dto
        [HttpPost("api/desk")]
        public ActionResult CreateDesk([FromBody] Desk desk)
        {
            _logger.LogInformation("Create desk.");
            var response = _deskService.AddDesk(desk);
            return Ok(response);
        }

        [HttpDelete("api/desk/{id}")]
        public ActionResult DeleteDesk(int deskId)
        {
            _logger.LogInformation("Delete desk.");
            var response = _deskService.DeleteDesk(deskId);
            return Ok(response);
        }


    }
}