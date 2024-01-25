using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SacramentFinder.Data;
using SacramentFinder.Models;
using System.Net;

namespace SacramentFinder.Services
{
    
    public class CreateUserService : ICreateUserService
    {
        private UserContext _userContext;
        public CreateUserService(UserContext userContext)
        {
            _userContext = userContext;
        }
        public string CreateUser(CreateUser user, CancellationToken cancellationToken)
        {
            if (user.Username == null || user.Password == null || user.ConfirmPassword == null)
                throw new Exception("Username, password, and confirm password are required fields."); 
            
            if(user.Password != user.ConfirmPassword)
                throw new Exception("Password and confirm password must match.");

            //TODO: Add logic to create user in database
            SaveUserToDatabase(user);

            return "User created successfully.";
        }

        private void SaveUserToDatabase(CreateUser user)
        {
            _userContext.Users.Add(new Users { Username = user.Username, Password = user.Password});
            _userContext.SaveChanges();
        }
    }
}
