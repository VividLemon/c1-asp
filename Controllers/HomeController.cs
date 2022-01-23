using C1.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace C1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //return View();
            int hour = DateTime.Now.Hour;
            string greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            greeting += $" the current time is {DateTime.Now.ToShortTimeString()}";

            ViewBag.Greeting = greeting;
            return View();
        }
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm(Model.GuestResponse guest)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(guest);
                return View("Thanks", guest);
            }
            else
            {
                return View();
            }
        }
        public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where(resp => resp.WillAttend == true));
        }
    }
}
