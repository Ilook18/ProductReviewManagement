using System;
using System.Collections.Generic;

namespace Product_Review_Management
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Management operation = new Management();
            List<Product_Review> list = new List<Product_Review>()
            {
                new Product_Review() { productid = 1, userid = 1, rating = 5, review = "Best", isLike = true },
                new Product_Review() { productid = 2, userid = 2, rating = 3, review = "Nice", isLike = true },
                new Product_Review() { productid = 3, userid = 3, rating = 5, review = "Best", isLike = true },
                new Product_Review() { productid = 4, userid = 4, rating = 2, review = "Bad", isLike = false },
                new Product_Review() { productid = 5, userid = 5, rating = 4, review = "Good", isLike = true },
                new Product_Review() { productid = 6, userid = 6, rating = 2, review = "Bad", isLike = false },
                new Product_Review() { productid = 7, userid = 7, rating = 1, review = "Bad", isLike = false },
                new Product_Review() { productid = 8, userid = 8, rating = 4, review = "Good", isLike = true },
                new Product_Review() { productid = 9, userid = 9, rating = 5, review = "Best", isLike = true },
                new Product_Review() { productid = 10, userid = 10, rating =2, review = "Bad", isLike = false },
                new Product_Review() { productid = 10, userid = 10, rating =4, review = "Good", isLike = true },
                new Product_Review() { productid = 10, userid = 10, rating =5, review = "Best", isLike = true },
                new Product_Review() { productid = 10, userid = 10, rating =3, review = "Nice", isLike = true },
                new Product_Review() { productid = 10, userid = 10, rating =1, review = "Bad", isLike = false },

            };
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter your Choice Number to Execute the Program Press- 1-DisplayData 2-Retrive Data,3-Retrieve using Product id,4-Count,5-Productid and Review,6-Skip Records,7-Productid and Review,8-DataTable,9-Retrieve from dataTable,10-AverageRating,11-Retrieve Review Message,12-Retrieve Userid 13-Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Management.Display(list);
                        break;
                    case 2:
                        int id;
                        Management.SelectTopRatingRecords( list,out id);
                        break;
                    case 3:
                        Management.SelectRecordsUsingProductId(list);
                        break;
                    case 4:
                        Management.SelectCountOfRecords(list);
                        break;
                    case 5:
                        Management.SelectProductidAndReview(list);
                        break;
                    case 6:
                        Management.SkipTopFiveRecords(list);
                        break;
                    case 7:
                        Management.SelectProductidAndReview(list);
                        break;
                    case 8:
                        operation.RetrieveRecordsFromDataTable();
                        break;
                    case 9:
                        operation.RetrieveRecordsFromDataTable();
                        break;
                    case 10:
                        operation.AveragePerProductId(list);
                        break;
                    case 11:
                        operation.RetrieveReviewMessage(list, "Nice");
                        break;
                    case 12:
                        operation.RetriveUserId();
                        break;
                    case 13:
                        flag = false;
                        break;
                }
            }

        }
    }
}
