using BookReviews.Models;
using System;
using Xunit;

namespace Tests
{
    public class AuthorTests
    {
        [Fact]
        // Test when the user gives all the right answers
        public void RightAnswerTest()
        {
            // Arrange
            var quiz = new QuizVM()
            {
                UserAnswer1 = "Victor Hugo",
                UserAnswer2 = "1812",
                UserAnswer3 = "false"
            };

            // Act
            quiz.CheckAnswers();

            // Assert
            Assert.True("Right" == quiz.RightOrWrong1 &&
                "Right" == quiz.RightOrWrong2 && "Right" == quiz.RightOrWrong3);
        }

        // Test when the user gives all wrong answers
        [Fact]
        public void WrongAnswerTest()
        {
            // Arrange
            var quiz = new QuizVM()
            {
                UserAnswer1 = "Victor Huge",
                UserAnswer2 = "",
                UserAnswer3 = "true"
            };

            // Act
            quiz.CheckAnswers();

            // Assert
            Assert.True("Wrong" == quiz.RightOrWrong1 &&
                "Wrong" == quiz.RightOrWrong2 && "Wrong" == quiz.RightOrWrong3);
        }

    }
}
