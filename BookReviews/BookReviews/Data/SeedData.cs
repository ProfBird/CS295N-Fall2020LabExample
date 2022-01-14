﻿using System;
using BookReviews.Models;
using Microsoft.EntityFrameworkCore;

namespace BookReviews.Data
{
    public static class SeedData
    {
        /// <summary>
        /// This is an extension method for the ModelBuilder class
        /// It is called from BookReviewContext.OnModelCreating
        /// </summary>
        /// <param name="modelBuilder"></param>
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // Add three Users who will be the reviewer
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserID = 1,
                    Name = "Brian Bird"
                },
                new User
                {
                    UserID = 2,
                    Name = "Emma Watson"
                },
                new User
                {
                    UserID = 3,
                    Name = "Daniel Radliiffe"
                }
            );

            modelBuilder.Entity<Review>().HasData(
                new 
                {
                    ReviewID = 1,
                    ReviewerUserID = 2,
                    BookTitle = "Prince of Foxes",
                    AuthorName = "Samuel Shellabarger",
                    ReviewText = "Great book, a must read!",
                    ReviewDate = DateTime.Parse("11/1/2020")
                },
                // Another review of the same book
                new
                {
                    ReviewID = 2,
                    ReviewerUserID = 3,
                    BookTitle = "Prince of Foxes",
                    AuthorName = "Samuel Shellabarger",
                    ReviewText = "I love the clever, witty dialog",
                    ReviewDate = DateTime.Parse("11/15/2020")
                }
            );

            // The next two reviews will be by the same reviewer

            modelBuilder.Entity<Review>().HasData(
                new
                {
                    ReviewID = 3,
                    ReviewerUserID = 1,
                    BookTitle = "Virgil Wander",
                    AuthorName = "Lief Enger",
                    ReviewText = "Wonderful book, written by a distant cousin of mine.",
                    ReviewDate = DateTime.Parse("11/30/2020")
                },

                new
                {
                    ReviewID = 4,
                    ReviewerUserID = 1,
                    BookTitle = "Ivanho",
                    AuthorName = "Sir Walter Scott",
                    ReviewText = "It was a little hard going at first, but then I loved it!",
                    ReviewDate = DateTime.Parse("11/1/2020")
                }
            );
        }
    }
}

