using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

using GeosemanticTest.Models;

namespace GeosemanticTest.Controllers {
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return RedirectToAction("Index", "Home");
        }

        public IActionResult SignIn()
        {
            return RedirectToAction("Index", "SignIn");
        }

        [HttpPost]
        public JsonResult Register(string Email, string Password)
        {
            var user = new User();
            user.Email = Email;
            user.Password = Password;

            _context.Users.Add(user);
            _context.SaveChanges();

            var result = new {status = "success", data = user};

            return Json(result);
        }


    }
}