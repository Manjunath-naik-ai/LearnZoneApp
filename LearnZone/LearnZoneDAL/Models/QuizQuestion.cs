using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace LearnZoneDAL.Models
{
    public class QuizQuestion
    {
        public int QuestionId { get; set; }
        public int QuizId { get; set; }
        public string QuestionText { get; set; } = null!;

        // Navigation properties
        public Quiz Quiz { get; set; } = null!;
        public ICollection<QuizOption> Options { get; set; } = new List<QuizOption>();
    }
}