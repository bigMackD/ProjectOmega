using ProjectOmega.Data.Entities;

namespace ProjectOmega.Data.Models.Order
{
    public class EditOrderModel
    {
        public long Id { get; set; }

        public long ClientId { get; set; }
        public Status Status { get; set; }
     
        public Entities.User UserResponsible { get; set; }
        public Entities.User UserInvoice { get; set; }
    }
}
