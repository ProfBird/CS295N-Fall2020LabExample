using System;
using System.Collections.Generic;
using System.Linq;
using BookReviews.Models;
using BookReviews.Repos;
using Microsoft.AspNetCore.Mvc;

namespace BookReviews.Controllers
{
    public class BookController : Controller
    {
        IReviewRepository repo;

        public BookController(IReviewRepository r)
        {
            repo = r;
        }

        /// <summary>
        /// List all books (without duplicates)
        /// </summary>
        public IActionResult Index()
        {
            List<string> titles = repo.Reviews
                .Select(review => review.BookTitle)
                .Distinct()
                .ToList();

            return View(titles);
            /* Note: .GroupBy is not supported by EF Core 3.1 so this doesn't work:
                List<Review> reviews = repo.Reviews
                    .GroupBy(review => review.BookTitle)
                    .Select(group => group.FirstOrDefault())
                    .ToList();
            */
        }

        // Invoke the view which contains a form for entering a review
        public IActionResult Review()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Review(Review model)
        {
            model.ReviewDate = DateTime.Now;
            // Store the model in the database
            repo.AddReview(model);

            return View(model);
        }

        public IActionResult Reviews()
        {
            // Get all reviews in the database
            List<Review> reviews = repo.Reviews.ToList<Review>(); // Use ToList to convert the IQueryable to a list
            // var reviews = context.Reviews.Include(book => book.Reviewer).ToList<Review>();
            return View(reviews);
        }
    }
};
