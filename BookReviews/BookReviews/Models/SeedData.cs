using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookReviews.Models
{
    public class SeedData
    {
        BookReviewContext context;
        public SeedData(BookReviewContext c)
        {
            context = c;
        }

        // public static void Seed(IApplicationBuilder app)
        public void Seed()
        {
            // BookReviewContext context = app.ApplicationServices.GetRequiredService<BookReviewContext>();
            if (!context.Reviews.Any())  // temporary so I can add reviews to existing data
            {
                Review review = new Review
                {
                    BookTitle = "Prince of Foxes",
                    AuthorName = "Samuel Shellabarger",
                    ReviewText = "Great book, a must read!",
                    Reviewer = new User { Name = "Emma Watson" },
                    ReviewDate = DateTime.Parse("11/1/2020")
                };
                context.Reviews.Add(review);

                review = new Review
                {
                    BookTitle = "Virgil Wander",
                    AuthorName = "Lief Enger",
                    ReviewText = "Wonderful book, written by a distant cousin of mine.",
                    Reviewer = new User { Name = "Brian Bird" },
                    ReviewDate = DateTime.Parse("11/30/2020")
                };

                context.Reviews.Add(review);
                context.SaveChanges(); // save all the data
            }
        }
    }
}
