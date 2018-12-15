using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ProjectOmega.Data.Models.Client;
using ProjectOmega.Repositories.ClientsRepository;

namespace ProjectOmega.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        ClientsRepository repo = new ClientsRepository();

        // GET: api/Clients
        [HttpGet]
        public IEnumerable<ClientModel> Get()
        {
            return repo.GetAll();
        }

        // GET: api/Clients/5
        [HttpGet("{id}", Name = "Get")]
        public ClientModel Get(long id)
        {
            return repo.GetById(id);
        }
    }
}
