using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnZoneDAL.Models
{
    public class QuizOption
    {
        public int OptionId { get; set; }
        public int QuestionId { get; set; }
        public string OptionText { get; set; } = null!;
        public bool IsCorrect { get; set; }

        // Navigation property
        public QuizQuestion Question { get; set; } = null!;
    }
}