using System.Collections.Generic;
using System.Linq;
using FlexOffice.Api.Dto;
using FlexOffice.Data.Models;

namespace FlexOffice.Api.Serialization
{
    public class DeskMapper
    {
        public static DeskReadDTO SerializeDeskModelToDtoModel (Desk desk)
        {
            return new DeskReadDTO
            {
                Id = desk.Id,
                DeskNumber = desk.DeskNumber,
                IsFree = desk.IsFree,
                ShortDeskDescription = desk.ShortDeskDescription,
                LocationId = desk.LocationId
            };
        }

        public static Desk SerializeDeskDtoModelToDeskModel(DeskReadDTO desk)
        {
            return new Desk 
            {
                Id = desk.Id,
                DeskNumber = desk.DeskNumber,
                IsFree = desk.IsFree,
                ShortDeskDescription = desk.ShortDeskDescription,
                LocationId = desk.LocationId
            };
        }

        public static List<DeskReadDTO> SerializeDesksListToDeskReadDtoModel (IEnumerable<Desk> desks)
        {
            return desks.Select(desk => new DeskReadDTO {
                Id = desk.Id,
                DeskNumber = desk.DeskNumber,
                IsFree = desk.IsFree,
                ShortDeskDescription = desk.ShortDeskDescription,
                LocationId = desk.LocationId
            }).ToList();
        }

        public static Desk SerializeDeskCreateDtoModel (DeskCreateDTO desk)
        {
            return new Desk {
                DeskNumber = desk.DeskNumber,
                IsFree = desk.IsFree,
                ShortDeskDescription = desk.ShortDeskDescription,
                LocationId = desk.LocationId
            };
        }


    }
}