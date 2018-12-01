using System.Collections.Generic;
using ProjectOmega.Data.Models.Order;

namespace ProjectOmega.Repositories.OrdersRepositories
{
    public interface IOrdersRepository
    {
        void Create(AddOrderModel order);
        void Update(EditOrderModel order);
        IEnumerable<OrderModel> GetAll();
    }
}
