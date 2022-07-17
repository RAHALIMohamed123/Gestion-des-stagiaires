using Gestion_des_Stagiaires.Models;
using Gestion_des_Stagiaires.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestion_des_Stagiaires.Controllers
{
    public class TraineesController : Controller
    {
        private readonly ILogger<TraineesController> _logger;
        private readonly ApplicationDbContext _context;
        public TraineesController(ILogger<TraineesController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Stagiaires()
        {
            var trainees = new TraineesList();

            trainees.Trainees = await _context.Trainees.ToListAsync(); // Method that gets/builds a list of employees, expected return type List<Employee>


            return View("Stagiaires", trainees);

        }
        public async Task<IActionResult>  Delete(int id)
        {
            var traineeForDelete = await _context.Trainees.FirstOrDefaultAsync(x => x.Id == id);
            if (traineeForDelete != null)
            {
                 _context.Trainees.Remove(traineeForDelete); // Method that gets/builds a list of employees, expected return type List<Employee>
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Stagiaires");
        }
        [HttpPost]
        public async Task<IActionResult> Add(Trainee trainee)
        {
            
            trainee.TrainerId = 1;
            await _context.Trainees.AddAsync(trainee); // Method that gets/builds a list of employees, expected return type List<Employee>
           await _context.SaveChangesAsync();
            return RedirectToAction("Stagiaires");

        }

        public async Task<IActionResult> Update(Trainee trainee)
        {
            trainee.TrainerId = 1;
            //var traineeToUpdate = await _context.Trainees.FirstOrDefaultAsync(x => x.Id == trainee.Id);
            _context.Trainees.Update(trainee); // Method that gets/builds a list of employees, expected return type List<Employee>
            await _context.SaveChangesAsync();
            return RedirectToAction("Stagiaires");

        }

        public PartialViewResult AddTrainee_PartialView()
        {
          

            ViewBag.Message = "Example Data from Server"; //Using ViewBag Just for example, use ViewModel Instead

            return PartialView("~/Views/Trainees/AddTrainee.cshtml");
        }


        public async Task<PartialViewResult> UpdateTrainee_PartialView(int id)
        {
           

            ViewBag.Message = "Example Data from Server"; //Using ViewBag Just for example, use ViewModel Instead
            var traineeForUpdate = await _context.Trainees.FirstOrDefaultAsync(x => x.Id == id);

            return PartialView("~/Views/Trainees/UpdateTrainee.cshtml",traineeForUpdate);
        }


        public async Task<PartialViewResult> GetTrainee_PartialView(int id)
        {
           

            ViewBag.Message = "Example Data from Server"; //Using ViewBag Just for example, use ViewModel Instead
            var trainee = await _context.Trainees.FirstOrDefaultAsync(x => x.Id == id);

            return PartialView("~/Views/Trainees/Details.cshtml", trainee);
        }


       
    }
}
