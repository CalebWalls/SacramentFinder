using Microsoft.AspNetCore.Mvc;
using SacramentFinder.Models;

namespace SacramentFinder.Services
{
    public interface ICreateUserService
    {
        Task<string> CreateUser(CreateUser user, CancellationToken cancellationToken);
    }
}
