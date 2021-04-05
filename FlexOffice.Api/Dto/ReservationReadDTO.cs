using System;

namespace FlexOffice.Api.Dto
{
    public class ReservationReadDTO
    {           
        public int Id { get; set; }
        public DateTime ReservedDay { get; set; }
        public int DeskId { get; set; }
        public DeskReadDTO DeskReadDto {get; set;}
        public int UserId { get; set; }
        public UserReadDTO UserReadDto {get; set;}
    }
}