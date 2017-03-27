using Microsoft.AspNetCore.Mvc;
namespace WebApplication.Controllers
{
    public class ChildsController : Controller
    {
        public IActionResult Index()
        {
            return View("Index", Family.Childs);
        }
    }
}