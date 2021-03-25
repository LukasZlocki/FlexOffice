using System;
using System.Collections.Generic;
using System.Linq;
using FlexOffice.Data;
using FlexOffice.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace FlexOffice.Services
{

    public class LocationService : ILocationService
    {
        private readonly OfficeDbContext _db;

        public LocationService(OfficeDbContext db)
        {
            _db = db;
        }


        // CREATE
        /// <summary>
        /// Create location object
        /// </summary>
        /// <param name="location"></param>
        /// <returns><Location></returns>
        public ServiceResponse<Location> CreateLocation(Location location)
        {
            try
            {
                var service = _db.Locations.Add(location);
                _db.SaveChanges();
                return new ServiceResponse<Location> 
                {
                    IsSucess = true,
                    Message = "Location added.",
                    Time = DateTime.UtcNow,
                    Data = location
                };

            }
            catch( Exception e)
            {
                return new ServiceResponse<Location> 
                {
                    IsSucess = false,
                    Message = e.StackTrace,
                    Time = DateTime.UtcNow,
                    Data = location
                };

            }
        }

        // READ
        /// <summary>
        /// Returns locations list
        /// </summary>
        /// <returns>List<Location></returns>
        public List<Location> GetAllLocations()
        {
            var service = _db.Locations.ToList();
            return service;
        }

        /// <summary>
        /// Returns location by primary key
        /// </summary>
        /// <param name="locationId"></param>
        /// <returns><Location></returns>
        public Location GetLocationById(int locationId)
        {
            var service = _db.Locations.Find(locationId);
            return service;
        }

        /*
        // UPDATE
        public ServiceResponse<bool> UpdateLocation(int locationId)
        {
            throw new System.NotImplementedException();
        }
        */

        // DELETE
        /// <summary>
        /// Delete location by primary key
        /// </summary>
        /// <param name="locationId"></param>
        /// <returns>ServiceResponse<bool></returns>
        public ServiceResponse<bool> DeleteLocation(int locationId)
        {
            var location = _db.Locations.Find(locationId);
            if (location == null)
            {
                return new ServiceResponse<bool> 
                {
                    IsSucess = false,
                    Message = "No location found",
                    Time = DateTime.UtcNow,
                    Data = false
                };
            }
    
            try 
            {
                _db.Locations.Remove(location);
                 _db.SaveChanges();
                return new ServiceResponse<bool> 
                {
                    IsSucess = true,
                    Message = "Location removed.",
                    Time = DateTime.UtcNow,
                    Data = true
                };
            }
            catch (Exception e)
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