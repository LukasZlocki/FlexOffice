using System.ComponentModel.DataAnnotations;

namespace FlexOffice.Data.Models
{
    public class Location
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(30)]
        public string Country { get; set; }
        [MaxLength(30)]
        public string UnitLocation { get; set; }
        [MaxLength(30)]
        public string OfficeName { get; set; }
        [MaxLength(5)]
        public string OfficeNumber { get; set; }
        [MaxLength(250)]
        public string ShortLocationDescription { get; set; }
        [MaxLength(250)]
        public string UrlPhoto { get; set; }
    }
}