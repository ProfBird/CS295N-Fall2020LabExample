using System;
using BookReviews.Controllers;
using BookReviews.Models;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace Tests
{
    public class BookTests
    {
        [Fact]
        public void ReviewPostDateTest()
        {

            // Arrange
            var bookController = new BookController();
            var review = new Review();

            // Act - pass a model to the controller method
            var result = (ViewResult)bookController.Review(review);
            var modelFromResult = (Review)result.Model;

            // Assert
            // Check that the current date got added to the model
            Assert.Equal(modelFromResult.ReviewDate.Date, DateTime.Now.Date);
        }
    }
}
