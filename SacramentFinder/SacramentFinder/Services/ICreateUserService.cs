using Microsoft.AspNetCore.Mvc;
using SacramentFinder.Models;

namespace SacramentFinder.Services
{
    public interface ICreateUserService
    {
        string CreateUser(CreateUser user, CancellationToken cancellationToken);
    }
}
