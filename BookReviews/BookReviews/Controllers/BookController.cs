using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookReviews.Models;
using BookReviews.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookReviews.Controllers
{
    public class BookController : Controller
    {
        IBookRepository repo;

        public BookController(IBookRepository r)
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
            var reviews = repo.Reviews.ToList<Review>();
            return View(reviews);
        }
    }
};
