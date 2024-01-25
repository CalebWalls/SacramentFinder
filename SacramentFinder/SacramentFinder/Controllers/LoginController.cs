using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SacramentFinder.Models;
using SacramentFinder.Services;

namespace SacramentFinder.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _identityService;

        public LoginController(ILoginService identityService)
        {
            _identityService = identityService;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginUser user, CancellationToken cancellationToken)
        {
            return await _identityService.Login(user.Username, user.Password, cancellationToken);
        }
    }
}
