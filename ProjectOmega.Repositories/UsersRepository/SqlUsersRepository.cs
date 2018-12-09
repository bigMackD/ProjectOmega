using System;
using System.Collections.Generic;
using System.Linq;
using ProjectOmega.Data.Entities;
using ProjectOmega.Data.Models.Role;
using ProjectOmega.Data.Models.User;
using ProjectOmega.DAL.MsSql.Services;

namespace ProjectOmega.Repositories.UsersRepository
{
    public class SqlUsersRepository : IUsersRepository
    {
        private readonly ApplicationDbContext _context;
        public SqlUsersRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Create(AddUserModel user)
        {
            var role = _context.Roles.SingleOrDefault(r => r.Id == user.RoleId);
            _context.Users.Add(new User
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                IsActive = true,
                Password = user.Password,
                Role = role
            });
            _context.SaveChanges();
        }

        public void Update(EditUserModel user)
        {
            throw new NotImplementedException();
        }

        public void Remove(long id)
        {
            var userToBeRemoved = _context.Users.SingleOrDefault(u => u.Id == id);
            _context.Remove(userToBeRemoved);
            _context.SaveChanges();
        }

        public IEnumerable<UserModel> GetAll()
        {
            return _context.Users.Select(u => new UserModel
            {
                Id = u.Id,
                FirstName = u.FirstName,
                LastName = u.LastName,
                Role = new RoleModel
                {
                    Id = u.Role.Id,
                    Name = u.Role.Name
                }
            });
        }
    }
}
