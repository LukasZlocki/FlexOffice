using FlexOffice.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FlexOffice.Data
{
    public class OfficeDbContext : IdentityDbContext
    {
        public OfficeDbContext()
        {

        }

        public OfficeDbContext(DbContextOptions<OfficeDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Desk> Desks {get; set;}
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<AppUser> AppUsers { get; set; }

        
    }
}