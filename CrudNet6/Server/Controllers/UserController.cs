using CrudNet6.Server.Service;
using CrudNet6.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrudNet6.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IServiceUser serviceUser;

        public UserController(IServiceUser service)
        {
            serviceUser = service;
        }

        [HttpGet]
        public async Task<List<User>> GetUsersAsync()
        {
            return await Task.FromResult(serviceUser.GetUsers());
        }

        [HttpPost]
        public void Post([FromBody] User user)
        {
            serviceUser.PostUser(user);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            User user = serviceUser.GetById(id);
            if(user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpPut]
        public void Put([FromBody] User user)
        {
            serviceUser.PutUser(user);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            serviceUser.DeleteUser(id);
            return Ok();
        }

    }
}
