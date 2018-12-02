using System.ComponentModel.DataAnnotations;

namespace ProjectOmega.Data.Entities
{
    public class Role
    {
        [Key]
        public long Id { get; set; }

        public string Name { get; set; }
    }
}
