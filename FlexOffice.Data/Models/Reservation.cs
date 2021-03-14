using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlexOffice.Data.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }
        public DateTime ReservedDay { get; set; }

        [Display(Name="Desk number")]
        public int DeskId { get; set; }
        [ForeignKey("DeskId")]
        public Desk Desk { get; set; }

        [Display(Name="User")]
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public AppUser AppUser { get; set; }
    }
}