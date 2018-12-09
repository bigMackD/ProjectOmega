using ProjectOmega.Data.Entities;
using ProjectOmega.Data.Models.Role;

namespace ProjectOmega.Data.Models.User
{
    public class AddUserModel
    {
        public string Password { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public AddRoleModel Role { get; set; }
        public bool IsActive { get; set; }
    }
}
