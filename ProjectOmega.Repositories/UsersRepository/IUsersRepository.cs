using System.Collections.Generic;
using ProjectOmega.Data.Models.User;

namespace ProjectOmega.Repositories.UsersRepository
{
    public interface IUsersRepository
    {
        void Create(AddUserModel user);
        void Update(EditUserModel user);
        void Remove(long id);
        IEnumerable<UserModel> GetAll();
    }
}
