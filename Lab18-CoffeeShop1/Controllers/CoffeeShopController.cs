using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab18_CoffeeShop1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab18_CoffeeShop1.Controllers
{
    public class CoffeeShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Registration()
        {

            return View(new RegisterUser());
        }
        [HttpPost]
        public IActionResult Registration(RegisterUser newUser)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Welcome", newUser);
            }
            return View(newUser);
        }
        public IActionResult Welcome(RegisterUser user)
        {
            return View(user);
        }
    }
}