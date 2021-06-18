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
    public class TeamController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private FitnessContext db;

        public TeamController(ILogger<HomeController> logger, FitnessContext injectedContext)
        {
            _logger = logger;
            db = injectedContext;
        }

        public IActionResult Index(string ID)
        {   
            var team = db.Teams.Single(t => t.ID == ID);
            team.Users = db.Users.Where(u => u.TeamID == ID).ToList();

            SetActiveUser((string) TempData["ActiveUser"]);
            return View(team);
        }

        public IActionResult Join(string ID)
        {
            var team = db.Teams.Single(t => t.ID == ID);
            team.Users = db.Users.Where(u => u.TeamID == ID).ToList();

            var user = db.Users.Single(u => u.ID == (string) TempData["ActiveUser"]);
            user.TeamID = ID;
            team.Users.Add(user);

            db.Teams.Update(team);
            db.Users.Update(user);
            db.SaveChanges();

            SetActiveUser((string) TempData["ActiveUser"]);
            return RedirectToAction("Index", "User");
        }

        public IActionResult Search(string tag = null)
        {
            List<Team> teams;

            if (tag != null)
                teams = db.Teams.Where(t => t.ID.Contains(tag.ToUpper())).ToList();
            else
            {
                var r = new Random();
                teams = db.Teams.AsEnumerable().OrderBy(order => r.Next()).ToList();
            }
            
            var model = new TeamViewModel
            {
                Teams = teams
            };

            SetActiveUser((string) TempData["ActiveUser"]);
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Team team)
        {
            var user = db.Users.Single(u => u.ID == (string) TempData["ActiveUser"]);

            if (user.Petokens >= 50)
            {
                user.TeamID = team.ID;
                user.Petokens -= 50;
                team.Users = new List<User>();
                team.Users.Add(user);

                team.ID = team.ID.ToUpper();

                db.Teams.Add(team);
                db.Users.Update(user);
                db.SaveChanges();
            }
            
            SetActiveUser((string) TempData["ActiveUser"]);
            return RedirectToAction("Index", "User");
        }

        public IActionResult LeaveTeam(string ID)
        {
            var team = db.Teams.Single(t => t.ID == ID);
            team.Users = db.Users.Where(u => u.TeamID == ID).ToList();

            var user = db.Users.Single(u => u.ID == (string) TempData["ActiveUser"]);

            team.Users.Remove(user);
            user.TeamID = null;

            if (team.Users.Count == 0)
                db.Teams.Remove(team);
            else
                db.Teams.Update(team);

            db.Users.Update(user);
            db.SaveChanges();

            SetActiveUser((string) TempData["ActiveUser"]);
            return RedirectToAction("Index", "User");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private void SetActiveUser(string user)
        {
            TempData["ActiveUser"] = user;
        }
    }
}
