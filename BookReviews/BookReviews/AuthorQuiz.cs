using System;
using System.Collections.Generic;

namespace BookReviews
{
    public static class AuthorQuiz
    {
        public static string CheckAnswer(int questionNumber, string answer)
        {
            string correct;
            switch (questionNumber)
            {
                case 1:
                    correct = answer == "Victor Hugo"? "Right" : "Wrong";
                    break;
                case 2:
                    correct = answer == "1812" ? "Right" : "Wrong";
                    break;
                case 3:
                    correct = answer == "false" ? "Right" : "Wrong";
                    break;
                default:
                    correct = "Not a question";
                    break;
            }
            return correct;
        }
    }
}
