using HouseEX.Persistence;
using HouseEX.Persistence.Model;
using Microsoft.AspNetCore.Mvc;

namespace HouseEx.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController
    {
        private readonly IHouseExRepository repository;

        public UsersController(IHouseExRepository repository)
        {
            this.repository = repository;
        }


        [HttpGet]
        public IEnumerable<User> Get()
        {
            return this.repository.GetUsers().Take(10);
        }
    }
}