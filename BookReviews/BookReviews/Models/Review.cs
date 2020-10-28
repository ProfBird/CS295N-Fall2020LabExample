using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookReviews.Models
{
    public class Review
    {
        public string BookTitle { get; set; }
        public string AuthorName { get; set; }
        public User Reviewer { get; set; }
        public string ReviewText { get; set; }
        public DateTime ReviewDate { get; set; }
    }
}
