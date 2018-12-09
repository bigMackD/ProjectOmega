using ProjectOmega.Data.Entities;

namespace ProjectOmega.Data.Models.Order
{
    public class OrderModel
    {
        public string Number { get; set; }

        public long ClientId { get; set; }
        public Status Status;
    
        public Entities.User UserAdded { get; set; }
        public Entities.User UserResponsible { get; set; }
        public Entities.User UserInvoice { get; set; }
    }
}
