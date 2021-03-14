using System.Collections.Generic;
using FlexOffice.Data.Models;

namespace FlexOffice.Services
{

    public class LocationService : ILocationService
    {

        public LocationService()
        {
            
        }

        // CREATE
        public ServiceResponse<Location> CreateLocation(Location location)
        {
            throw new System.NotImplementedException();
        }

        // READ
        public List<Location> GetAllLocations()
        {
            throw new System.NotImplementedException();
        }

        public Location GetLocationById(int id)
        {
            throw new System.NotImplementedException();
        }

        // UPDATE
        public ServiceResponse<bool> UpdateLocation(int locationId)
        {
            throw new System.NotImplementedException();
        }

        // DELETE
        public ServiceResponse<bool> DeleteLocation(int locationId)
        {
            throw new System.NotImplementedException();
        }

        
    }
}