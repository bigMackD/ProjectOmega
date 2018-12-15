using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectOmega.Data.Models.User;
using ProjectOmega.Repositories.UsersRepository;

namespace ProjectOmega.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersRepository _users;

        public UsersController(IUsersRepository users)
        {
            _users = users;
        }

        /// <summary>
        /// Returns list of all users
        /// </summary>
        /// <returns>IEnumerable of OrderModel</returns>
        [HttpGet]
        public ActionResult<IEnumerable<UserModel>> Get()
        {
            return Ok(_users.GetAll());
        }

        /// <summary>
        /// Returns user with specified ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult<UserModel> Get(long id)
        {
            return _users.GetById(id);
        }


        /// <summary>
        /// Adds new user to DB
        /// </summary>
        /// <param name="user"></param>
        [HttpPost]
        public void Post([FromBody] AddUserModel user)
        {
            _users.Create(user);
        }

       
        /// <summary>
        /// Updates specified user
        /// </summary>
        /// <param name="user"></param>
        [HttpPut]
        public void Put([FromBody] EditUserModel user)
        {
            _users.Update(user);
        }

      
        /// <summary>
        /// Deletes specified user
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            _users.Remove(id);
        }
    }
}
