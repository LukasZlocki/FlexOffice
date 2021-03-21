using System.Collections.Generic;
using FlexOffice.Data.Models;

namespace FlexOffice.Services
{
    public interface ILocationService
    {
         // CREATE
        public ServiceResponse<Data.Models.Location> CreateLocation (Data.Models.Location location);

        // READ
        public List<Location> GetAllLocations();      
        public Location GetLocationById(int id);

        /*
        // UPDATE
        public ServiceResponse<bool> UpdateLocation (int locationId);
        */

        //DELETE
        public ServiceResponse<bool> DeleteLocation (int locationId);
    }
}