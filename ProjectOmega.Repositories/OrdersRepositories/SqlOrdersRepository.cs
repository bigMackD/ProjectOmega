using System;
using System.Collections.Generic;
using System.Linq;
using ProjectOmega.Data.Entities;
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
            new Order()
            {
                ClientId = order.ClientId,
                Status = order.Status,
                UserAdded = order.UserAdded
            };
        }

        public void Update(EditOrderModel orderToBeEdited)
        {
            _context.Remove(_context.Orders.FirstOrDefault(x => x.Id == orderToBeEdited.Id));
            Order newOrder =  new Order()
            {
                Id = orderToBeEdited.Id,
                ClientId = orderToBeEdited.ClientId,
                Status = orderToBeEdited.Status,
                UserResponsible = orderToBeEdited.UserResponsible,
                UserInvoice = orderToBeEdited.UserInvoice,
            };
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

