using BookReviews.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BookReviews.Repositories
{
    public class BookRepository : IBookRepository
    {
        private BookReviewContext context;

        // Get all reviews + associated data by using the EF Include method.
        public IQueryable<Review> Reviews
        {
            get
            {
                return context.Reviews.Include(review => review.Reviewer);
            }
        }


        public BookRepository(BookReviewContext appDbContext)
        {
            context = appDbContext;
        }

        public void AddReview(Review review)
        {
            context.Reviews.Add(review);
            context.SaveChanges();
        }

        public Review GetReviewByTitle(string title)
        {
            Review review = context.Reviews.FirstOrDefault(r => r.BookTitle == title);
            return review;
        }
    }
}
