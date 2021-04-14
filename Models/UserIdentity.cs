using System;
using System.Security.Cryptography;

namespace FitPETZ.Models
{
    public class UserIdentity
    {
        public string ID { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public User Users { get; set; }
    }
}