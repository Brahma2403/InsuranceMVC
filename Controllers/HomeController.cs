using InsuranceMVC.Models;
using InsuranceMVC.Repository;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceMVC.Controllers
{
    public class HomeController : Controller
    {
        UserRepository userRep = null;

        public HomeController(InsuranceDbContext htx) //Dependency injection
        {
            userRep = new UserRepository(htx);
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AdminLogin(IFormCollection fm)
        {
            string userName = fm["txUser"];
            string password = fm["txPsw"];
            string role = fm["Role"];
            bool b = userRep.IsValidUser(userName, password, role);
            if (b)
            {
                if (role == "Admin")
                {
                    HttpContext.Session.SetString("UserName", userName);
                    return RedirectToAction("Index", "Policy");
                }
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Error = "Invalid Login Credentials";
                return View("HomeErrorView");
            }
        }

        [HttpPost]
        public IActionResult Login(IFormCollection ifrm)
        {
            string userName = ifrm["txUser"];
            string password = ifrm["txPsw"];
            string role = ifrm["Role"];
            bool b = userRep.IsValidUser(userName, password, role);
            if (b)
            {
                if (role == "User")
                {
                    HttpContext.Session.SetString("UserName", userName);
                    return RedirectToAction("Index", "UserPolicy");
                }
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Error = "Invalid Login Credentials";
                return View("HomeErrorView");
            }
        }
    }
}
