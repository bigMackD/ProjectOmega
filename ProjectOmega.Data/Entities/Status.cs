using System.ComponentModel.DataAnnotations;

namespace ProjectOmega.Data.Entities
{
    public class Status
    {
        [Key]
        public long StatusId { get; set; }

        public string Name { get; set; }
    }
}
