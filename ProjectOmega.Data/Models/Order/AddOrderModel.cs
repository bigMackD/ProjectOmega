namespace ProjectOmega.Data.Models.Order
{
    public class AddOrderModel
    {
        public long ClientId { get; set; }
        public int Status { get; set; }

        public long UserAddedId { get; set; }
    }
}
