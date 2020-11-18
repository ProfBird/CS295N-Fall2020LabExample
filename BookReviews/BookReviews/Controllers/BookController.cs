using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookReviews.Models;
using BookReviews.Repos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookReviews.Controllers
{
    public class BookController : Controller
    {
        IReviewRepository repo;

        public BookController(IReviewRepository r)
        {
            repo = r;
        }


        public IActionResult Index()
        {
            
            return View();
        }

        // Invoke the view with form for entering a review
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
