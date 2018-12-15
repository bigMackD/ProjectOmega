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
            var userToBeEdited = _context.Users.SingleOrDefault(x => x.Id == user.Id);
            var role = _context.Roles.SingleOrDefault(x => x.Id == user.RoleId);

            userToBeEdited.Id = user.Id;
            userToBeEdited.FirstName = user.FirstName;
            userToBeEdited.LastName = user.LastName;
            userToBeEdited.Password = user.Password;
            userToBeEdited.IsActive = true;
            userToBeEdited.Role = role;

            _context.SaveChanges();

        }

        public UserModel GetById(long id)
        {
            return _context.Users.Select(x => new UserModel()
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Role = new RoleModel()
                {
                    Id = x.Role.Id,
                    Name = x.Role.Name
                },

            }).SingleOrDefault(u => u.Id == id);
        }

        public void Remove(long id)
        {
            var userToBeRemoved = _context.Users.SingleOrDefault(u => u.Id == id);
            _context.Users.Remove(userToBeRemoved);
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
