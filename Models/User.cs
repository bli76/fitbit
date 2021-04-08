using System.Collections.Generic;

namespace FitPETZ.Models
{
    public class User
    {
        public string ID { get; set; }
        public string? TeamID { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public char Gender { get; set; }
        public int? Petokens { get; set; } = 0;
        public int? WeeklyPoints { get; set; } = 0;
        public Team Team { get; set; }
        public Pet Pet { get; set; }
        public ICollection<Challenge> Challenges { get; set; }
    }
}