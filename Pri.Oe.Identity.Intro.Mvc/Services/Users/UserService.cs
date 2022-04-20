using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Pri.Oe.Identity.Intro.Mvc.Services.Users
{
    public class UserService : IUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public async Task LoginAsync(string userName, string password)
        {
            //check hardcoded credentials
        }
        

        public async Task LogoutAsync()
        {
            
        }
    }
}
