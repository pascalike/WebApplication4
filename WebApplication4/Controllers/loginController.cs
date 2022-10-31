using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class loginController : Controller
    {
        public IActionResult Index(string uname, string psw)
        {

            person p1 = new person(uname, psw);

            return View(p1);
        }
        public IActionResult page()
        {
            return View();
        }
        public IActionResult loginpage()
        {
            


            return View();
        }
        public IActionResult register()
        {
            return View();
        }
        public IActionResult dashboard()
        {
            return View();
        }
    }
}
