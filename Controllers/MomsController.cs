using Microsoft.AspNetCore.Mvc;
namespace WebApplication.Controllers
{
    public class MomsController : Controller
    {
        public IActionResult Index()
        {
            return View("Index", Family.Moms);
        }
    }
}