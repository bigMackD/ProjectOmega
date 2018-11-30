namespace ProjectOmega.Data.Models.Order
{
    public class EditOrderModel
    {
        public long ClientId { get; set; }
        public long StatusId { get; set; }

        public long UserResponsibleId { get; set; }
        public long UserInvoiceId { get; set; }
    }
}
