using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookReviews.Models
{
    public class QuizVM
    {
        // User's answers and whether right or wrong for three questions
        public String UserAnswer1 {get; set;}
        public String RightOrWrong1 { get; set; }
        public String UserAnswer2 { get; set; }
        public String RightOrWrong2 { get; set; }
        public String UserAnswer3 { get; set; }
        public String RightOrWrong3 { get; set; }

        // Checks each answer to see if it's right or wrong
        // Returns "Right" or "Wrong"
        public void CheckAnswers()
        {
            RightOrWrong1 = UserAnswer1 == "Victor Hugo" ? "Right" : "Wrong";
            RightOrWrong2 = UserAnswer2 == "1812" ? "Right" : "Wrong";
            RightOrWrong3 = UserAnswer3 == "false" ? "Right" : "Wrong";
        }
    }
}
