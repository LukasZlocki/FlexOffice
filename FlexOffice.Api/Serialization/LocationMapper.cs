using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FlexOffice.Api.Dto;
using FlexOffice.Data.Models;

namespace FlexOffice.Api.Serialization
{
    public class LocationMapper
    {

        public static LocationReadDTO SerializeToLocationDTO(Location location)
        {
            return new LocationReadDTO
            {
                Id = location.Id,
                Country = location.Country,
                UnitLocation = location.UnitLocation,
                OfficeName = location.OfficeName,
                OfficeNumber = location.OfficeNumber,
                ShortLocationDescription = location.ShortLocationDescription,
                UrlPhoto = location.UrlPhoto
            };
        }
        
        public static Location SerializeToLocation(LocationReadDTO location)
        {
            return new Location
            {
                Country = location.Country,
                UnitLocation = location.UnitLocation,
                OfficeName = location.OfficeName,
                OfficeNumber = location.OfficeNumber,
                ShortLocationDescription = location.ShortLocationDescription,
                UrlPhoto = location.UrlPhoto
            }; 
        }

        public static List<LocationReadDTO> SerializeListLocationToDTO (IEnumerable<Location> locations)
        {
            return locations.Select(location => new LocationReadDTO
            {
                Id = location.Id,
                Country = location.Country,
                UnitLocation = location.UnitLocation,
                OfficeName = location.OfficeName,
                OfficeNumber = location.OfficeNumber,
                ShortLocationDescription = location.ShortLocationDescription,
                UrlPhoto = location.UrlPhoto
            }).ToList();
        }

        public static Location SerializeCreateLocation (LocationCreateDTO location)
        {
            return new Location 
            {
                Country = location.Country,
                UnitLocation = location.UnitLocation,
                OfficeName = location.OfficeName,
                OfficeNumber = location.OfficeNumber,
                ShortLocationDescription = location.ShortLocationDescription,
                UrlPhoto = location.UrlPhoto
            };
        }


    }
}