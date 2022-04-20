using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pri.Oe.Identity.Intro.Mvc.Services.Users;
using Pri.Oe.Identity.Intro.Mvc.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pri.Oe.Identity.Intro.Mvc.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(UsersLoginViewModel usersLoginViewModel)
        {
            if(!ModelState.IsValid)
            {
                return View(usersLoginViewModel);
            }
            await _userService.LoginAsync(usersLoginViewModel.UserName,
                usersLoginViewModel.Password);
            return RedirectToAction("Index");
        }
    }
}
