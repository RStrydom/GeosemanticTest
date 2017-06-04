using Microsoft.AspNetCore.Mvc;
using GeosemanticTest.Models;

namespace GeosemanticTest.Controllers {
    public class SignInController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


    }
}