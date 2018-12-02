using System.ComponentModel.DataAnnotations;

namespace ProjectOmega.Data.Entities
{
    public class Status
    {
        [Key]
        public long Id { get; set; }

        public string Name { get; set; }
    }
}
