using ProjectOmega.Data.Models.Role;

namespace ProjectOmega.Data.Models.User
{
    public class UserModel
    {
        public long Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public RoleModel Role { get; set; }
    }
}
