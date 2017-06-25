using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Fiver.Mvc.Layout.Models.Home;

namespace Fiver.Mvc.Layout.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new UserViewModel
            {
                Firstname = "Tahir",
                Surname = "Naushad"
            };
            return View(model);
        }
    }
}
