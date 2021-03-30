using System;

namespace FlexOffice.Api.Dto
{
    public class ReservationDTO
    {           
        public int Id { get; set; }
        public DateTime ReservedDay { get; set; }
        public int DeskId { get; set; }
        public int UserId { get; set; }
    }
}