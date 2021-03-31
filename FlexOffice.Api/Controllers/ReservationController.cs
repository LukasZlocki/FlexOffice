using FlexOffice.Api.Dto;
using FlexOffice.Api.Serialization;
using FlexOffice.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FlexOffice.Api.Controllers
{
    public class ReservationController : ControllerBase
    {
        private readonly ILogger<ReservationController> _logger;
        private readonly IReservationService _reservationService;

        public ReservationController(IReservationService reservationService, ILogger<ReservationController> logger)
        {
            _logger = logger;
            _reservationService = reservationService;
        }
        
        [HttpGet("api/reservation")]
        public ActionResult GetAllReservation()
        {
            _logger.LogInformation("Get all reservations.");
            var service = _reservationService.GetAllReservations();
            var reservationsMapper = ReservationMapper.SerializeReservationsToDTO(service);
            return Ok(reservationsMapper);
        }

        [HttpGet("api/reservation/{id}")]
        public ActionResult GetReservation(int id)
        {
            _logger.LogInformation("Get reservation.");
            var service = _reservationService.GetReservationById(id);
            var reservationMapper = ReservationMapper.SerializeReservationToDTO(service);
            return Ok(reservationMapper);
        }

        [HttpDelete("api/reservation/{id}")]
        public ActionResult DeleteReservation(int id)
        {
            _logger.LogInformation("Delete reservation.");
            var response = _reservationService.DeleteReservation(id);
            return Ok(response);
        }

        // ToDo : Add TDO or/and serialization
        [HttpPost("api/reservation")]
        public ActionResult CreateReservation([FromBody] ReservationCreateDTO reservation)
        {
            _logger.LogInformation("Create reservation.");
            var reservationMapper = ReservationMapper.SerializeCreateReservation(reservation);
            var response = _reservationService.CreateReservation(reservationMapper);
            return Ok(response);
        }


    }
}