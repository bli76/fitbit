using System.Collections.Generic;

namespace FitPETZ.Models
{
    public class UserIndexViewModel
    {
        public User User { get; set; }
        public Pet Pet { get; set; }
        public IList<Team> Teams { get; set; }
        public IList<User> Users { get; set; }
    }
}