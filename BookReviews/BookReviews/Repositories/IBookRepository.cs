using BookReviews.Models;
using System.Linq;

namespace BookReviews.Repositories
{
    public interface IBookRepository
    {
        IQueryable<Review> Reviews { get; }  // property that can contain a collection of books
        void AddReview(Review review);     // method to add a review to the DB
        Review GetReviewByTitle(string title);      // method to retrieve a review from the DB
    }
}
