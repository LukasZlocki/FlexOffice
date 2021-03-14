using System.Collections.Generic;
using FlexOffice.Data.Models;

namespace FlexOffice.Services
{
    public interface IReservationService
    {
        // CREATE
        public ServiceResponse<Data.Models.Reservation> CreateReservation (Data.Models.Reservation reservation);

        // READ
        public List<Reservation> GetAllReservations();
        public Data.Models.Reservation GetReservationById(int reservationId);
        public List<Reservation> GetUserReservationListByUserId(int userId);

        // UPDATE
        public ServiceResponse<bool> UpdateReservation(int reservationId);

        // DELETE 
        public ServiceResponse<bool> DeleteReservation(int reservationId);
    }
}