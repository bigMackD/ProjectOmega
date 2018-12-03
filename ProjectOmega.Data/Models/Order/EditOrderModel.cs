using ProjectOmega.Data.Entities;

namespace ProjectOmega.Data.Models.Order
{
    public class EditOrderModel
    {
        public long Id { get; set; }

        public long ClientId { get; set; }
        public Status Status { get; set; }
     
        public User UserResponsible { get; set; }
        public User UserInvoice { get; set; }
    }
}
