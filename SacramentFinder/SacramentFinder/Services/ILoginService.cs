using Microsoft.AspNetCore.Mvc;

namespace SacramentFinder.Services
{
    public interface ILoginService
    {
        Task<IActionResult> Login(string username, string password, CancellationToken cancellationToken);
    }
}
