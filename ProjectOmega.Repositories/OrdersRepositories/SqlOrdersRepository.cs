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
            });
        }

        public OrderModel GetById(long id)
        {
           var order =  _context.Orders.SingleOrDefault(x => x.Id == id);
            if (order == null)
                return null;
            else
            {
                var status = (Status) order.Status;

                return new OrderModel()
                {
                    Number = order.Number,
                    ClientId = order.ClientId,
                    UserAdded = new UserModel
                    {
                        Id = order.UserAdded.Id,
                        FirstName = order.UserAdded.FirstName,
                        LastName = order.UserAdded.LastName
                    },
                    UserResponsible = new UserModel
                    {
                        Id = order.UserResponsible.Id,
                        FirstName = order.UserResponsible.FirstName,
                        LastName = order.UserResponsible.LastName
                    },
                    UserInvoice = new UserModel
                    {
                        Id = order.UserInvoice.Id,
                        FirstName = order.UserInvoice.FirstName,
                        LastName = order.UserInvoice.LastName
                    },

                    Status = status
                };
            }

           
        }

        public void Remove(long id)
        {
            var orderToBeRemoved = _context.Orders.SingleOrDefault(x => x.Id == id);
            _context.Orders.Remove(orderToBeRemoved);
            _context.SaveChanges();
        }
    }
}

