namespace ProjectOmega.Data.Models.User
{
    public class EditUserModel
    {
        public long Id { get; set; }
        public string Password { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long RoleId { get; set; }
    }
}
