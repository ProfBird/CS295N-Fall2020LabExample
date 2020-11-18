﻿using BookReviews.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookReviews.Repos
{
    public class ReviewRepository : IReviews
    {
        private BookReviewContext context;

        // constructor
        public ReviewRepository(BookReviewContext c)
        {
            context = c;
        }

        public IQueryable<Review> Reviews 
        { 
            get 
            { 
                // Get all the Review objects in the Reviews DbSet
                // and include the Reivewer object in each Review.
                return context.Reviews.Include(review => review.Reviewer);
            }
        }

public void AddReview(Review review)
        {
            throw new NotImplementedException();
        }

        public Review GetReviewByBookTitle(string title)
        {
            throw new NotImplementedException();
        }
    }
}
