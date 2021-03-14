using System.ComponentModel.DataAnnotations;

namespace FlexOffice.Data.Models
{
    public class AppUser
    {
       [Key]
       public int Id { get; set; } 
       public string UserLog { get; set; }
       public string Password { get; set; }
       public string Email { get; set; }
    }
}