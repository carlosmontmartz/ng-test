using Microsoft.AspNetCore.Mvc;

public class RegistrationController : Controller
{
        public IActionResult Index()
        {
            var Register = new RegisterVM();
            Register.lstChilds = Family.Childs;
            Register.lstMoms = Family.Moms;
            return View("Index", Register);
        }
}