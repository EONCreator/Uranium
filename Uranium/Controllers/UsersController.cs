using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Uranium.Domain.Core.Entities.User;
using Uranium.Domain.Data.Repositories;

namespace Uranium.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IEntityRepository _repository;
        public UsersController(IEntityRepository repository)
        {
            _repository = repository;
        }

        /*[HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _repository.Entity<User>().ToListAsync());
        }*/
    }
}
