using Microsoft.AspNetCore.Mvc;

namespace SacramentFinder.Services
{
    public class LoginService : ILoginService
    {
        public async Task<IActionResult> Login(string username, string password, CancellationToken cancellationToken)
        {
            return new OkObjectResult("Login Successful");
        }
    }
}