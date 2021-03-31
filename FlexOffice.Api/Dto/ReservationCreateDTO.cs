using System;
using FlexOffice.Data.Models;

namespace FlexOffice.Api.Dto
{
    public class ReservationCreateDTO
    {
        public DateTime ReservedDay { get; set; }
        public int DeskId { get; set; }
        public Desk Desk { get; set; }
        public int UserId { get; set; }
    }
}