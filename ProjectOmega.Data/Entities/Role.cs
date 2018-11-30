using System.ComponentModel.DataAnnotations;

namespace ProjectOmega.Data.Entities
{
    public class Role
    {
        [Key]
        public long RoleId { get; set; }

        public string Name { get; set; }
    }
}
