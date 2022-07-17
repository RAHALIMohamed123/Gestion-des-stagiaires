using Gestion_des_Stagiaires.Models;
using Gestion_des_Stagiaires.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Gestion_des_Stagiaires.Controllers
{
   
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        
        public IActionResult Login()
        {
            return View();
        }

       
        public IActionResult Home()
        {
            return View();
        }
     

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        [HttpPost]
        public async Task<IActionResult> Login(string nom,string prenom, string password)
        {
            // we must verefy account in database
            var admin = await _context.Administrators.Where(x => x.FirstName == nom && x.lastName == prenom && x.Password == password).FirstOrDefaultAsync();

            if (admin != null)
            {
                //HttpContext.Session.SetString("nom", nom+prenom);
               
                return RedirectToAction("Home");
            }
            else
            {
                ViewBag.error = "Invalid Account";
                return View("Login");
            }
        }
        [Route("logout")]
        [HttpGet]
        public IActionResult Logout()
        {
            // HttpContext.Session.Remove("nom");
            return View("Login");
        }
      
    }
}
