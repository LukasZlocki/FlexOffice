using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlexOffice.Data.Models
{
    public class Desk
    {
        [Key]
        public int Id { get; set; }
        public int DeskNumber { get; set; }
        public bool IsFree { get; set; }
        
        [MaxLength(250)]
        public string ShortDeskDescription { get; set; }
        
        public int LocationId {get; set;}
        [ForeignKey("LocationId")]
        public Location Location { get; set; }
    }
}