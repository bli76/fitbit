using System;

namespace FitPETZ.Models
{
    public class Challenge
    {
        public int ID { get; set; }
        public string PlayerID { get; set; }
        public DateTime Date { get; set; }
        public bool Completed { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal? Quantity { get; set; }
        public int? Duration { get; set; }
        public int Reward { get; set; }
        public User User { get; set; }
    }
}