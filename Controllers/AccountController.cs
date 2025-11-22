using Microsoft.AspNetCore.Mvc;
using To_DoList_AspMVC.Data;

namespace To_DoList_AspMVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Logout()
        {
            //HttpContext.Session.Remove("UserEmail");
            HttpContext.Session.Clear();
            return View("Login");
        }
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            var user = _context.Clients.FirstOrDefault(c => c.Email == email && c.Password == password);
            if (user != null)
            {
                HttpContext.Session.SetString("UserEmail", user.Email);
                // Successful login logic here (e.g., set session, redirect)
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.ErrorMessage = "Invalid email or password.";
                return View();
            }
        }

    }
}
