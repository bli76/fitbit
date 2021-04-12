using System;

namespace FitPETZ.Models
{
    public class ChallengeAssignments
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public int Reward { get; set; }
    }
}