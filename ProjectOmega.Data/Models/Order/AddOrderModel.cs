using ProjectOmega.Data.Entities;

namespace ProjectOmega.Data.Models.Order
{
    public class AddOrderModel
    {
        public long ClientId { get; set; }
        public Status Status { get; set; }

        public User UserAdded { get; set; }
    }
}
