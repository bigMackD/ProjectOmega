using System.Collections.Generic;
using ProjectOmega.Data.Models.Client;

namespace ProjectOmega.Repositories.ClientsRepository
{
    public interface IClientsRepository
    {
        ClientModel GetById(long id);
        IEnumerable<ClientModel> GetAll();

    }
}
