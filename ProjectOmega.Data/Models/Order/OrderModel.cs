using ProjectOmega.Data.Entities;
using ProjectOmega.Data.Models.User;

namespace ProjectOmega.Data.Models.Order
{
    public class OrderModel
    {
        public string Number { get; set; }

        public long ClientId { get; set; }
        public Status Status;
    
        public UserModel UserAdded { get; set; }
        public UserModel UserResponsible { get; set; }
        public UserModel UserInvoice { get; set; }
    }
}
