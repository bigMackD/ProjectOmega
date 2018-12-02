using System.ComponentModel.DataAnnotations;

namespace ProjectOmega.Data.Entities
{
    public class Order
    {
        [Key]
        public long Id { get; set; }

        public string Number { get; set; }

        public long ClientId { get; set; }
        public Status Status { get; set; }

        public User UserAdded { get; set; }
        public User UserResponsible { get; set; }
        public User UserInvoice { get; set; }
    }
    // TODO enum status
}
