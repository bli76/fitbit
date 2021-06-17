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
            var user = db.Users.Single(u => u.ID == (string) TempData["ActiveUser"]);
            user.Challenges = db.Challenges.Where(c => c.UserID == user.ID && !c.Completed).ToList();

            if (user.Challenges.Count == 0)
            {
                NewChallenge(user);
                NewChallenge(user);
                NewChallenge(user);
            }

            var model = new UserIndexViewModel
            {
                User = user,
                Pet = db.Pets.Single(u => u.UserID == (string) TempData["ActiveUser"]),
                Teams = db.Teams.ToList(),
            };
            if (model.User.TeamID != null)
                model.Users = db.Users.Where(u => u.TeamID == model.User.TeamID).ToList();
            
            SetActiveUser((string) TempData["ActiveUser"]);
            return View(model);
        }

        [Route("User/CompleteChallenge/{chID:int}")]
        public IActionResult CompleteChallenge(int chID)
        {
            var ch = db.Challenges.ToList().Single(c => c.ID == chID);
            ch.Completed = true;
            db.Challenges.Update(ch);

            var user = db.Users.Single(u => u.ID == (string) TempData["ActiveUser"]);
            NewChallenge(user);
            
            SetActiveUser((string) TempData["ActiveUser"]);
            return RedirectToAction("Index", "User");
        }

        private void NewChallenge(User user)
        {
            var r = new Random();
            var chas = db.ChallengeAssignments.AsEnumerable().OrderBy(order => r.Next()).First();

            var challenge = new Challenge
            {
                UserID = user.ID,
                Date = DateTime.Now,
                Completed = false,
                Title = chas.Title,
                Description = chas.Description,
                Reward = chas.Reward,
                User = user
            };
            user.Challenges.Add(challenge);

            db.Users.Update(user);
            db.SaveChanges();

            SetActiveUser((string) TempData["ActiveUser"]);
        }

        private void SetActiveUser(string user)
        {
            TempData["ActiveUser"] = user;
        }
    }
}