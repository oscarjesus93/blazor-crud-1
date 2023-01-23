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

    }
}
