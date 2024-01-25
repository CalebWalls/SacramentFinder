using Microsoft.AspNetCore.Mvc;
using SacramentFinder.Models;
using SacramentFinder.Services;

namespace SacramentFinder.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CreateUserController : Controller
    {
        private readonly ICreateUserService _createUserService;

        public CreateUserController(ICreateUserService createUserService)
        {
            _createUserService = createUserService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] CreateUser user, CancellationToken cancellationToken)
        {
            try
            {
                return Ok(_createUserService.CreateUser(user, cancellationToken));
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
