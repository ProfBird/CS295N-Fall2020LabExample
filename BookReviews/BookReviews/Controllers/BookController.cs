using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookReviews.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookReviews.Controllers
{
    public class BookController : Controller
    {
        BookReviewContext context;

        public BookController(BookReviewContext c)
        {
            context = c;
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
            context.Reviews.Add(model);
            context.SaveChanges();

            return View(model);
        }

        public IActionResult Reviews()
        {
            var reviews = context.Reviews.Include(book => book.Reviewer).ToList<Review>();
            return View(reviews);
        }
    }
};
