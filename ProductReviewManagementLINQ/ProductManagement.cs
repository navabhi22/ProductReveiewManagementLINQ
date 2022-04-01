using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagementLINQ
{
    internal class ProductManagement
    {
        public readonly DataTable dataTable = new DataTable();

        //UC2_Reterieve Top 3 records
        public void TopRecords(List<ProductReview> listProductReview)
        {
            var recordedData = (from productReviews in listProductReview
                                orderby productReviews.Rating descending
                                select productReviews).Take(3);

            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductId:-" + list.ProductId + " UserId:-" + list.UserId + " Ratings:-" + list.Rating + " Review:-" + list.Review + " IsLike:-" + list.isLike);
            }
        }

        // UC3_Retrieve records with rating greater then 3 and productID 1 or 4 or 9
        public void ReviewWithRatingGreaterThan3andProductId1or4o9(List<ProductReview> listProductReview)
        {
            var recordedData = (from productReviews in listProductReview
                                where ( productReviews.UserId==1 || productReviews.UserId == 1 || productReviews.UserId == 1 &&   productReviews.Rating > 3)
                                select productReviews);

            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductId:-" + list.ProductId + " UserId:-" + list.UserId + " Ratings:-" + list.Rating + " Review:-" + list.Review + " IsLike:-" + list.isLike);
            }
        }

        // UC4_ Number of reviews present for each productId
        public void CountReviewForEachProduct(List<ProductReview> listProductReview)
        {
            var recordedData = listProductReview.GroupBy(x => x.ProductId).Select(x => new { ProductId = x.Key, Count = x.Count() });
            Console.WriteLine("\nProductId and Count = ");

            foreach (var list in recordedData)
            {
                Console.WriteLine(list.ProductId + " = " + list.Count);
            }
        }
    }
}