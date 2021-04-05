using System.Collections.Generic;

namespace FlexOffice.Api.Dto
{
    public class LocationReadDTO
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string UnitLocation { get; set; }
        public string OfficeName { get; set; }
        public string OfficeNumber { get; set; }
        public string ShortLocationDescription { get; set; }
        public string UrlPhoto { get; set; }

        public List<DeskReadDTO> Desks {get; set;}
    }
}