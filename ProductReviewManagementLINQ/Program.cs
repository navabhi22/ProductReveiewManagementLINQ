using System;
using System.Collections.Generic;

namespace ProductReviewManagementLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management Problems Using LINQ");

            List<ProductReview> productReviewList = new List<ProductReview>()
            {
            new ProductReview() { ProductId = 1, UserId = 1, Rating = 4.5, Review = "Good", isLike=true},
            new ProductReview() { ProductId = 1, UserId = 2, Rating = 4.5, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 2, UserId = 2, Rating = 5, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 2, UserId = 3, Rating = 5, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 4, UserId = 4, Rating = 5, Review = "Nice", isLike=true },
            new ProductReview() { ProductId = 5, UserId = 1, Rating = 5, Review = "Nice", isLike=true },
            new ProductReview() { ProductId = 6, UserId = 4, Rating = 5, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 7, UserId = 3, Rating = 2.5, Review = "Good", isLike=false},
            new ProductReview() { ProductId = 4, UserId = 1, Rating = 1.5, Review = "Good", isLike=false },
            new ProductReview() { ProductId = 9, UserId = 3, Rating = 2.5, Review = "Bad", isLike=false },
            new ProductReview() { ProductId = 10, UserId = 1, Rating = 5, Review = "Bad", isLike=false },
            new ProductReview() { ProductId = 11, UserId = 5, Rating = 5, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 12, UserId = 5, Rating = 5, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 13, UserId = 6, Rating = 5, Review = "Bad", isLike=true },
            new ProductReview() { ProductId = 14, UserId = 1, Rating = 5, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 15, UserId = 4, Rating = 5, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 16, UserId = 1, Rating = 4.5, Review = "Good", isLike=true},
            new ProductReview() { ProductId = 17, UserId = 2, Rating = 4.5, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 18, UserId = 2, Rating = 5, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 19, UserId = 3, Rating = 5, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 20, UserId = 4, Rating = 5, Review = "Nice", isLike=true },
            new ProductReview() { ProductId = 21, UserId = 1, Rating = 5, Review = "Nice", isLike=true },
            new ProductReview() { ProductId = 22, UserId = 4, Rating = 5, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 23, UserId = 3, Rating = 2.5, Review = "Good", isLike=false},
            new ProductReview() { ProductId = 24, UserId = 1, Rating = 1.5, Review = "Good", isLike=false },
            new ProductReview() { ProductId = 25, UserId = 3, Rating = 2.5, Review = "Bad", isLike=false }
            };
            Console.WriteLine("Rows in the table = ");
            foreach (var list in productReviewList)
            {
                Console.WriteLine("Product id = " + list.ProductId + "User id = " + list.UserId + "Rating is = " + list.Rating + " Review is = " + list.Review + " isLike = " + list.isLike);
            }
            
            ProductManagement productManagement = new ProductManagement();
            productManagement.TopRecords(productReviewList);
        }
    }
}