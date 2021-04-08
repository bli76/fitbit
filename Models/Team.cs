using System.Collections.Generic;

namespace FitPETZ.Models
{
    public class Team
    {
        public string ID { get; set; }
        public string Motto { get; set; }
        public string Description { get; set; }
        public char Type { get; set; }
        public ICollection<User> Users { get; set; }
    }
}