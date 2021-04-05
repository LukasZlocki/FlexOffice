using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FlexOffice.Api.Dto;
using FlexOffice.Data.Models;

namespace FlexOffice.Api.Serialization
{
    public class ReservationMapper
    {
        public static ReservationReadDTO SerializeReservationToDTO (Reservation reservation)
        {
            return new ReservationReadDTO 
            {
                Id = reservation.Id,
                ReservedDay = reservation.ReservedDay,
                DeskId = reservation.DeskId,
                UserId = reservation.UserId,
            };
        }

        public static Reservation SerializeReservationFromDTO (ReservationReadDTO reservation)
        {
            return new Reservation 
            {
                Id = reservation.Id,
                ReservedDay = reservation.ReservedDay,
                DeskId = reservation.DeskId,
                UserId = reservation.UserId
            };
        }

        public static List<ReservationReadDTO> SerializeReservationsToDTO(IEnumerable<Reservation> reservations)
        {
            return reservations.Select(reservation => new ReservationReadDTO {
                Id = reservation.Id,
                ReservedDay = reservation.ReservedDay,
                DeskId = reservation.DeskId,
                DeskReadDto = DeskMapper.SerializeDeskModelToDtoModel(reservation.Desk),
                UserId = reservation.UserId,
                UserReadDto = UserMapper.SerializeUserModel(reservation.AppUser)
            }).ToList();
        }

        public static Reservation SerializeCreateReservation (ReservationCreateDTO reservation)
        {
            return new Reservation 
            {
                ReservedDay = reservation.ReservedDay,
                DeskId = reservation.DeskId,
                UserId = reservation.UserId
            };
        }

    }
}