using CoffeeShopLab20.Models;
using System.Web.Mvc;

namespace CoffeeShopLab20.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            ViewBag.Name = "Tammy";

            ViewBag.Score = 1234;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Registration()
        {
            return View();
        }
        //will need in future:
        //[HttpPost]
        public ActionResult Success(User user)
        {
            UsersController UC = new UsersController();
            UC.Create(user);

            if (ModelState.IsValid)
            {
                ViewBag.Firstname = "Welcome " + user.first_name;
                ViewBag.Contact = "Anxiously await our contact efforts - We will find you and bring coffee. The email we have on file is: " + user.email;
                return View();
            }
            else
            {
                return RedirectToAction("Error");
            }

        }
    }
}