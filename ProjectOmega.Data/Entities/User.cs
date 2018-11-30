using System.ComponentModel.DataAnnotations;

namespace ProjectOmega.Data.Entities
{
    public class User
    {
        [Key]
        public long UserId { get; set; }
        public string Password { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        public long RoleId { get; set; }
        public bool IsActive { get; set; }

        
    }
}
