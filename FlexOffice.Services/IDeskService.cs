using System.Collections.Generic;
using FlexOffice.Data.Models;

namespace FlexOffice.Services
{
    public interface IDeskService
    {
        // CREATE
        public ServiceResponse<Desk> AddDesk(Desk desk);

        // READ
        public List<Desk> GetAllDesks();
        public Data.Models.Desk GetDeskById (int id);
        public List<Desk> GetDesksByLocation( int locationId);

        // UPDATE
        public ServiceResponse<Desk> UpdateDesk(int deskId);

        // DELETE
        public ServiceResponse<bool> DeleteDesk(int deskId); 
    }
}