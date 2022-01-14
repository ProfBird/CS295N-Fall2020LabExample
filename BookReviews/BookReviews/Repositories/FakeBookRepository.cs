using BookReviews.Models;
using System.Collections.Generic;
using System.Linq;

namespace BookReviews.Repositories
{
    public class FakeBookRepository : IBookRepository
    {
        private List<Review> reviews = new List<Review>();
        public IQueryable<Review> Reviews
        {
            get { return reviews.AsQueryable<Review>(); }
        }

        public void AddReview(Review review)
        {
            review.ReviewID = reviews.Count;
            reviews.Add(review);
        }

        public Review GetReviewByTitle(string title)
        {
            var reveiw = reviews.Find(r => r.BookTitle == title);

            return reveiw;
        }
    }
}
