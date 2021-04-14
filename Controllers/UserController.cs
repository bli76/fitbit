using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FitPETZ.Models;
using FitPETZ.Data;

namespace FitPETZ.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private FitnessContext db;

        public UserController(ILogger<HomeController> logger, FitnessContext injectedContext)
        {
            _logger = logger;
            db = injectedContext;
        }

        public IActionResult Index()
        {
            var r = new Random();
            var model = new UserIndexViewModel
            {
                User = db.Users.Single(u => u.ID == (string) TempData["ActiveUser"]),
                Pet = db.Pets.Single(u => u.UserID == (string) TempData["ActiveUser"]),
                Challenges = db.ChallengeAssignments.AsEnumerable().OrderBy(order => r.Next()).Take(4),
                Teams = db.Teams.ToList(),
            };
            if (model.User.TeamID != null)
                model.Users = db.Users.Where(u => u.TeamID == model.User.TeamID).ToList();
            
            SetActiveUser((string) TempData["ActiveUser"]);
            return View(model);
        }
        private void SetActiveUser(string user)
        {
            TempData["ActiveUser"] = user;
        }
    }
}