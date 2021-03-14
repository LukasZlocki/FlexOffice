using System.Collections.Generic;
using FlexOffice.Data.Models;

namespace FlexOffice.Services
{
    public class DeskService : IDeskService
    {
        public DeskService()
        {
            
        }

        // CREATE
        public ServiceResponse<Desk> AddDesk(Desk desk)
        {
            throw new System.NotImplementedException();
        }

        // READ
        public List<Desk> GetAllDesks()
        {
            throw new System.NotImplementedException();
        }

        public Desk GetDeskById(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Desk> GetDesksByLocation(int locationId)
        {
            throw new System.NotImplementedException();
        }
        
        // UPDATE
        public ServiceResponse<Desk> UpdateDesk(int deskId)
        {
            throw new System.NotImplementedException();
        }

        // DELETE
        public ServiceResponse<bool> DeleteDesk(int deskId)
        {
            throw new System.NotImplementedException();
        }

  
    }
}