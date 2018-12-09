using System.Collections.Generic;
using System.Linq;
using ProjectOmega.Data.Entities;
using ProjectOmega.Data.Models.Order;
using ProjectOmega.Data.Models.User;
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
            var user = _context.Users.Single(u => u.Id == order.UserAddedId);
            var status = (Status)order.Status;

            Order newOrder = new Order
            {
                ClientId = order.ClientId,
                Status = status,
                UserAdded = user
            };
            _context.Orders.Add(newOrder);
            _context.SaveChanges();
        }

        public void Update(EditOrderModel order)
        {
            var orderToBeEdited =_context.Orders.SingleOrDefault(x => x.Id == order.Id);

            var userAdded = _context.Users.SingleOrDefault(u => u.Id == order.UserResponsibleId);
            var userResponsible = _context.Users.SingleOrDefault(u => u.Id == order.UserResponsibleId);
            var userInvoice = _context.Users.SingleOrDefault(u => u.Id == order.UserResponsibleId);
           
            orderToBeEdited.Id = order.Id;
            orderToBeEdited.Status = order.Status;
            orderToBeEdited.UserAdded = userAdded;
            orderToBeEdited.UserInvoice = userInvoice;
            orderToBeEdited.UserResponsible = userResponsible;
            orderToBeEdited.ClientId = order.ClientId;

            _context.SaveChanges();
        }

        public IEnumerable<OrderModel> GetAll()
        {
            return _context.Orders.Select(x => new OrderModel()
            {
                Number = x.Number,
                ClientId = x.ClientId,
                Status = x.Status,
                UserAdded = new UserModel
                {
                    Id = x.UserAdded.Id,
                    FirstName = x.UserAdded.FirstName,
                    LastName = x.UserAdded.LastName
                },
                UserResponsible = new UserModel
                {
                    Id = x.UserResponsible.Id,
                    FirstName = x.UserResponsible.FirstName,
                    LastName = x.UserResponsible.LastName,
                },
                UserInvoice = new UserModel
                {
                    Id = x.UserInvoice.Id,
                    FirstName = x.UserInvoice.FirstName,
                    LastName = x.UserInvoice.LastName,
                }
            }).ToList();
        }

        public OrderModel GetById(long id)
        {
          return  _context.Orders.Select(x => new OrderModel()
            {
                Id = x.Id,
                Number = x.Number,
                ClientId = x.ClientId,
                UserAdded = new UserModel
                {
                    Id = x.UserAdded.Id,
                    FirstName = x.UserAdded.FirstName,
                    LastName = x.UserAdded.LastName
                },
                UserResponsible = new UserModel
                {
                    Id = x.UserResponsible.Id,
                    FirstName = x.UserResponsible.FirstName,
                    LastName = x.UserResponsible.LastName
                },
                UserInvoice = new UserModel
                {
                    Id = x.UserInvoice.Id,
                    FirstName = x.UserInvoice.FirstName,
                    LastName = x.UserInvoice.LastName
                },
                Status = x.Status
            }).SingleOrDefault(o => o.Id == id);
        }

        public void Remove(long id)
        {
            var orderToBeRemoved = _context.Orders.SingleOrDefault(x => x.Id == id);
            _context.Orders.Remove(orderToBeRemoved);
            _context.SaveChanges();
        }
    }
}

