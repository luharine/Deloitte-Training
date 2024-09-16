using EmployeeMgmt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
namespace EmployeeMgmt.Controllers
{
   

    public class HomeController : Controller
    {
       

        EmployeeDbContext _context;

        
        public HomeController(EmployeeDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            
            return RedirectToAction("SignUp");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();

        }

        [HttpPost]
        public IActionResult Login(String Id, String Password)
        {
            
            User u1 = _context.Users.Find(Id);
            Console.WriteLine("User ID: " + (u1 != null ? u1.Id.ToString() : "User not found"));
            Console.WriteLine(u1.Id);
            if (u1.Id != null)
            {
                
                if (u1.Password.ToString() == Password)
                {
                    return RedirectToAction("Index","Employees");
                }

            }
            ViewBag.errormessage = "Incorrect Credentials";
            

        }



        [HttpGet]
        public IActionResult SignUp() {
        
        return View();
        }

       

        [HttpPost]
        public IActionResult SignUp(User obj)
        {

            _context.Users.Add(obj);
                _context.SaveChanges();
                return RedirectToAction("Login");
  
            
        }




        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
