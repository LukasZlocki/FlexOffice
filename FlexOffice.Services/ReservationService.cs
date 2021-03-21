using System;
using System.Collections.Generic;
using System.Linq;
using FlexOffice.Data;
using FlexOffice.Data.Models;

namespace FlexOffice.Services
{
    public class ReservationService : IReservationService
    {
        private readonly OfficeDbContext _db;
        
        public ReservationService(OfficeDbContext db)
        {
            _db = db;
        }

        // CREATE
        /// <summary>
        /// Create reservation
        /// </summary>
        /// <param name="reservation"></param>
        /// <returns>ServiceResponse<Reservation></returns>
        public ServiceResponse<Reservation> CreateReservation(Reservation reservation)
        {
            try
            {
                _db.Reservations.Add(reservation);
                _db.SaveChanges();
                 return new ServiceResponse<Reservation> 
                {
                    IsSucess = true,
                    Message = "Reservation created.",
                    Time = DateTime.UtcNow,
                    Data = reservation
                };

            }
            catch(Exception e)
            {
                 return new ServiceResponse<Reservation> 
                {
                    IsSucess = false,
                    Message = e.StackTrace,
                    Time = DateTime.UtcNow,
                    Data = reservation
                };
            }
        }

        // READ
        /// <summary>
        /// Return list of all reservations
        /// </summary>
        /// <returns>List<Reservation></returns>
        public List<Reservation> GetAllReservations()
        {
            var service = _db.Reservations.ToList();
            return service;
        }

        // READ
        /// <summary>
        /// Return reservation by primary key
        /// </summary>
        /// <param name="reservationId"></param>
        /// <returns><Reservation></returns>
        public Reservation GetReservationById(int reservationId)
        {
            var service = _db.Reservations.Find(reservationId);
            return service;
        }

        // READ
        /// <summary>
        /// Return list of user reservations by user primary key
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>List<Reservation></returns>
        public List<Reservation> GetUserReservationListByUserId(int userId)
        {
            var service = _db.Reservations.Where(u => u.UserId == userId).ToList();
            return service;
        }

        /*
        // UPDATE
        public ServiceResponse<bool> UpdateReservation(int reservationId)
        {
            throw new System.NotImplementedException();
        }
        */
        
        // DELETE
        /// <summary>
        /// Delete reservation by reservation primary key
        /// </summary>
        /// <param name="reservationId"></param>
        /// <returns>ServiceResponse<bool></returns>
        public ServiceResponse<bool> DeleteReservation(int reservationId)
        {
            var reservation = _db.Reservations.Find(reservationId);
            if (reservation == null)
            {
                return new ServiceResponse<bool> 
                {
                    IsSucess = false,
                    Message = "Reservation not found."
                    Time = DateTime.UtcNow,
                    Data = false
                };
            }
            try 
            {
                _db.Reservations.Remove(reservation);
                _db.SaveChanges();
                return new ServiceResponse<bool> 
                {
                    IsSucess = true,
                    Message = "Reservation deleted."
                    Time = DateTime.UtcNow,
                    Data = true
                };
            }
            catch(Exception e) 
            {
                return new ServiceResponse<bool> 
                {
                    IsSucess = false,
                    Message = e.StackTrace,
                    Time = DateTime.UtcNow,
                    Data = false
                };
            }

            
        }

        
    }
}