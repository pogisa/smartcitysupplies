using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using smartcitysupply.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using smartcitysupply.Models.HomeViewModels;

namespace smartcitysupply.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;

        }
        public IActionResult Index()
        {
            // messy - should be better ways to do this
            //ClaimsPrincipal currentUser = this.User;
            if(User.HasClaim(x => x.Type == "app_usertype" && (x.Value == "charity" || x.Value == "charityAdmin")))
            {
                return View("CharityIndex", new CharityViewModel());
            }
            //if (User.HasClaim(x => x.Type == "app_usertype" && (x.Value == "citizen")))
            //{
            //    return View("CitizenIndex", new CharityViewModel());
            //}
            return View();
        }

        [Authorize(Policy = "Charity")]
        public IActionResult CharityIndex()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
