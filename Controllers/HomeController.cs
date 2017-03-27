using Microsoft.AspNetCore.Mvc;
namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var Register = new RegisterVM();
            Register.lstChilds = Family.Childs;
            Register.lstMoms = Family.Moms;
            return View("Index", Register);
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
