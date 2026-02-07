using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnZoneDAL.Models
{
    public class UserQuizResult
    {
        public int ResultId { get; set; }
        public int UserId { get; set; }
        public int QuizId { get; set; }
        public int Score { get; set; }
        public DateTime AttemptDate { get; set; } = DateTime.Now;

        // Navigation property
        public Quiz Quiz { get; set; } = null!;
        // Optional: include User navigation if you have a User entity
        // public User User { get; set; } = null!;
    }
}
