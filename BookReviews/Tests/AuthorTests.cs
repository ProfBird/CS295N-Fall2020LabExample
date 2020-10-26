using System;
using BookReviews.Models;
using Xunit;

namespace Tests
{
    public class AuthorTests
    {
        [Fact]
        public void QuizVMCheckRightTest()
        {

            // Arrange
            var quiz = new QuizVM() {
                answer1 = "Victor Hugo",
                answer2 = "1812",
                answer3 = "false" };

            // Act - pass a model to the controller method
            quiz.CheckAnswers();

            // Assert
            // Check that the current date got added to the model
            Assert.True(quiz.check1 == "Right" &&
                quiz.check2 == "Right" &&
                quiz.check3 == "Right");
        }

        [Fact]
        public void QuizVMCheckWrongTest()
        {

            // Arrange
            var quiz = new QuizVM()
            {
                answer1 = "Charles Dickens",
                answer2 = "1984",
                answer3 = "true"
            };

            // Act - pass a model to the controller method
            quiz.CheckAnswers();

            // Assert
            // Check that the current date got added to the model
            Assert.True(quiz.check1 == "Wrong" &&
                quiz.check2 == "Wrong" &&
                quiz.check3 == "Wrong");
        }
    }
}
