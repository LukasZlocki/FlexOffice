using System.Collections.Generic;
using FlexOffice.Data.Models;

namespace FlexOffice.Services
{
    public class ReservationService : IReservationService
    {
        
        public ReservationService()
        {
            
        }

        public ServiceResponse<Reservation> CreateReservation(Reservation reservation)
        {
            throw new System.NotImplementedException();
        }

        public ServiceResponse<bool> DeleteReservation(int reservationId)
        {
            throw new System.NotImplementedException();
        }

        public List<Reservation> GetAllReservations()
        {
            throw new System.NotImplementedException();
        }

        public Reservation GetReservationById(int reservationId)
        {
            throw new System.NotImplementedException();
        }

        public List<Reservation> GetUserReservationListByUserId(int userId)
        {
            throw new System.NotImplementedException();
        }

        public ServiceResponse<bool> UpdateReservation(int reservationId)
        {
            throw new System.NotImplementedException();
        }
    }
}