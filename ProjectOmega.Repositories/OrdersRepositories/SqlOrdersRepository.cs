using System;
using System.Collections.Generic;
using System.Linq;
using ProjectOmega.Data.Models.Order;
using ProjectOmega.DAL.MsSql.Services;

namespace ProjectOmega.Repositories.OrdersRepositories
{
    public class SqlOrdersRepository : IOrdersRepository
    {
        private readonly ApplicationDbContext _context;
        public SqlOrdersRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Create(AddOrderModel order)
        {
            throw new NotImplementedException();
        }

        public void Update(EditOrderModel order)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderModel> GetAll()
        {
            return _context.Orders.Select(x => new OrderModel()
            {
                Number = "MockedNumber",
                ClientId = x.ClientId,
                UserAdded = x.UserAdded,
                UserResponsible = x.UserResponsible,
                UserInvoice = x.UserInvoice,
                Status = x.Status
            });
        }

        public OrderModel GetById(long id)
        {
           var order =  _context.Orders.SingleOrDefault(x => x.Id == id);
            return new OrderModel()
            {
                Number = order.Number,
                ClientId = order.ClientId,
                UserAdded = order.UserAdded,
                UserResponsible = order.UserResponsible,
                UserInvoice = order.UserInvoice,
                Status = order.Status
            };
        }
    }
}

