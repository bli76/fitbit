using System;
using System.Web;
using System.Text;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FitPETZ.Models;
using FitPETZ.Data;

namespace FitPETZ.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private FitnessContext db;

        public AccountController(ILogger<HomeController> logger, FitnessContext injectedContext)
        {
            _logger = logger;
            db = injectedContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string ID, string Password)
        {
            UserIdentity user = db.UserIdentities.SingleOrDefault(e => e.ID == ID);
            
            if (user == null)
                return View();

            string pass = HashPassword(Password, user.Salt);
            if (user.Password != pass)
                return View();
            
            User username = db.Users.SingleOrDefault(e => e.UserIdentityID == ID);
            TempData["ActiveUser"] = username.ID;
            return RedirectToAction("Index", "User");
        }
        public IActionResult PasswordReset()
        {
            return View();
        }
        [HttpPost]
        public IActionResult PasswordReset(string Email, string Username, string Password)
        {
            UserIdentity user = db.UserIdentities.SingleOrDefault(e => e.ID == Email);

            if (user == null)
                return View();
            
            user.Password = HashPassword(Password, user.Salt);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(UserIdentity user)
        {
            user.Salt = GenerateSalt();
            user.Password = HashPassword(user.Password, user.Salt);

            db.UserIdentities.Add(user);
            db.SaveChanges();

            TempData["activeEmail"] = user.ID;
            Console.WriteLine(TempData["activeEmail"]);
            return RedirectToAction("UserInfo");
        }
        public IActionResult UserInfo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UserInfo(User user)
        {
            user.UserIdentityID = (string) TempData["activeEmail"];

            db.Users.Add(user);
            db.SaveChanges();

            TempData["activeUser"] = user.ID;
            return RedirectToAction("PetInfo");
        }
        public IActionResult PetInfo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult PetInfo(Pet pet)
        {
            pet.Birthday = DateTime.Now;
            pet.UserID = (string) TempData["activeUser"];
            
            db.Pets.Add(pet);
            db.SaveChanges();

            return RedirectToAction("Index", "User");
        }
        private string GenerateSalt()
        {
            var rng = RandomNumberGenerator.Create();
            var saltBytes = new byte[16];
            rng.GetBytes(saltBytes);
            var saltText = Convert.ToBase64String(saltBytes);
            return saltText;
        }
        private string HashPassword(string pass, string salt)
        {
            var sha = SHA256.Create();
            var saltedPassword = pass + salt;
            var hashedPassword = Convert.ToBase64String(sha.ComputeHash(Encoding.Unicode.GetBytes(saltedPassword)));
            return hashedPassword;
        }
    }
}