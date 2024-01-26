using SacramentFinder.Data;
using SacramentFinder.Models;

namespace SacramentFinder.Services
{
    
    public class CreateUserService : ICreateUserService
    {
        private UserContext _userContext;
        public CreateUserService(UserContext userContext)
        {
            _userContext = userContext;
        }
        public async Task<string> CreateUser(CreateUser user, CancellationToken cancellationToken)
        {
            if (user.Username == null || user.Password == null || user.ConfirmPassword == null)
                throw new Exception("Username, password, and confirm password are required fields."); 
            
            if(user.Password != user.ConfirmPassword)
                throw new Exception("Password and confirm password must match.");

            //TODO: Add logic to create user in database
            await SaveUserToDatabase(user);

            return "User created successfully.";
        }

        private async Task SaveUserToDatabase(CreateUser user)
        {
            _userContext.Users.Add(new Users { Username = user.Username, Password = user.Password});
            await _userContext.SaveChangesAsync();
        }
    }
}
