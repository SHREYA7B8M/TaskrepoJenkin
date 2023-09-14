using Microsoft.AspNetCore.Mvc;
using WebAppUsers.Models;

namespace WebAppUsers.Controllers
{
    public class UserController : Controller
    {
        static List<User> users = new List<User>
        {
          new User() {UserId = 1,UserName="Sam",UserPwd="sam@1256",UserEmail="sam@yahoo.com"},
          new User() {UserId = 2,UserName="Amit",UserPwd="amit@123",UserEmail="amit@hotmail.com"},
          new User() {UserId = 3,UserName="Kumar",UserPwd="kumar@1256",UserEmail="kumar@mail.com"},
          new User() {UserId = 4,UserName="Anisha",UserPwd="a@rohan",UserEmail="a@yahoomail.com"},
          new User() {UserId = 5,UserName="Vidisha",UserPwd="v@isha",UserEmail="v5@gmail.com"},

        };
        public IActionResult Index()
        {
            return View(users);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new User());
        }
        [HttpPost]
        public IActionResult Create(User model)
        {
            if (ModelState.IsValid)
            {
                users.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
    }
}
