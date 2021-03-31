using FlexOffice.Api.Dto;
using FlexOffice.Api.Serialization;
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
            var desksMapper = DeskMapper.SerializeDesksListToDeskReadDtoModel(desks);
            return Ok(desksMapper);
        }

        [HttpGet("api/desk/{id}")]
        public ActionResult GetDeskById(int id)
        {
            _logger.LogInformation("Get desk by id.");
            var desk = _deskService.GetDeskById(id);
            var deskMapper = DeskMapper.SerializeDeskModelToDtoModel(desk);
            return Ok(deskMapper);
        }

        [HttpGet("api/desk/location/{id}")]
        public ActionResult GetDesksByLocation(int id)
        {
            _logger.LogInformation("Get desks by location.");
            var desks = _deskService.GetDesksByLocation(id);
            var desksMapper = DeskMapper.SerializeDesksListToDeskReadDtoModel(desks);
            return Ok(desksMapper);
        }
        
        // ToDo : Zastosowac Dto
        [HttpPost("api/desk")]
        public ActionResult CreateDesk([FromBody] DeskCreateDTO desk)
        {
            _logger.LogInformation("Create desk.");
            var deskMapper = DeskMapper.SerializeDeskCreateDtoModel(desk);
            var response = _deskService.AddDesk(deskMapper);
            return Ok(response);
        }

        [HttpDelete("api/desk/{id}")]
        public ActionResult DeleteDesk(int id)
        {
            _logger.LogInformation("Delete desk.");
            var response = _deskService.DeleteDesk(id);
            return Ok(response);
        }


    }
}