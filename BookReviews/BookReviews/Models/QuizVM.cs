using System;
namespace BookReviews.Models
{
    // View-Model for the Quiz page
    public class QuizVM
    {
        // User's answer to the first question
        public string answer1 { get; set; }
        // Result of checking the answer
        public string check1 { get; set; }

        // Second question results
        public string answer2 { get; set; }
        public string check2 { get; set; }

        // Third question results
        public string answer3 { get; set; }
        public string check3 { get; set; }

        // Check the user's answers
        public void CheckAnswers()
        {
            check1 = answer1 == "Victor Hugo" ? "Right" : "Wrong";
            check2 = answer2 == "1812" ? "Right" : "Wrong";
            check3 = answer3 == "false" ? "Right" : "Wrong";
        }
    }
}
