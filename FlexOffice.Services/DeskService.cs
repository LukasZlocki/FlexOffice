using System;
using System.Collections.Generic;
using System.Linq;
using FlexOffice.Data;
using FlexOffice.Data.Models;

namespace FlexOffice.Services
{
    public class DeskService : IDeskService
    {
        private readonly OfficeDbContext _db;

        public DeskService(OfficeDbContext db)
        {
            _db = db;
        }

        // CREATE
        /// <summary>
        /// Add a new desk record
        /// </summary>
        /// <param name="desk">Desk instance</param>
        /// <returns>ServiceResponse<Desk></returns>
        public ServiceResponse<Desk> AddDesk(Desk desk)
        {
            try {
                _db.Desks.Add(desk);
                _db.SaveChanges();
                return new ServiceResponse<Desk>
                {
                    IsSucess = true,
                    Message = "Desk added.",
                    Time = DateTime.UtcNow,
                    Data = desk
                };

            }
            catch (Exception e) {
                return new ServiceResponse<Desk>
                {
                    IsSucess = false,
                    Message = e.StackTrace,
                    Time = DateTime.UtcNow,
                    Data = desk
                };

            }
        }

        // READ
        /// <summary>
        /// Returns list of all desks
        /// </summary>
        /// <returns>List<Desk></returns>
        public List<Desk> GetAllDesks()
        {
            var service = _db.Desks.ToList();
            return service;
        }

        // READ
        /// <summary>
        /// Returns Desk object by primary key
        /// </summary>
        /// <param name="id"></param>
        /// <returns><Desk></returns>
        public Desk GetDeskById(int id)
        {
            var service = _db.Desks.Find(id);
            return service;
        }

        // READ
        /// <summary>
        /// Returns list of Desks objects
        /// </summary>
        /// <param name="locationId"></param>
        /// <returns>List<Desk></returns>
        public List<Desk> GetDesksByLocation(int locationId)
        {
            var service = _db.Desks.Where(l => l.Location.Id == locationId).ToList();
            return service;
        }
        
        // UPDATE
        /*
        public ServiceResponse<Desk> UpdateDesk(int deskId)
        {
            try{

            }
            catch(Exception e){

            }
        }
        */

        // DELETE
        /// <summary>
        /// Delete Desk object by primary key
        /// </summary>
        /// <param name="deskId"></param>
        /// <returns>ServiceResponse<bool></returns>
        public ServiceResponse<bool> DeleteDesk(int id)
        {
            var desk = _db.Desks.Find(id);

            if(desk == null)
            {
                return new ServiceResponse<bool>
                {
                    IsSucess = false,
                    Message = "No desk found.",
                    Time = DateTime.UtcNow,
                    Data = false
                };
            }

            try {
                _db.Desks.Remove(desk);
                _db.SaveChanges();
                return new ServiceResponse<bool>
                {
                    IsSucess = true,
                    Message = "Desk removed",
                    Time = DateTime.UtcNow,
                    Data = true
                };


            }
            catch(Exception e) {
                Console.WriteLine("Error. Not able to remove desk");
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