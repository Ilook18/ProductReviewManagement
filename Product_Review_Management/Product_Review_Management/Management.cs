using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;

namespace Product_Review_Management
{
   public class Management
    {
        DataTable dataTable = new DataTable();
        public static void Display(List<Product_Review> list)
        {
            foreach (Product_Review product in list)
            {
                Console.WriteLine("Productid:" + product.productid + "UserId:" + product.userid + "Rating:" + product.rating
                    + "Review" + product.review + "isLike" + product.isLike);
            }
        }

        public static void SelectTopRatingRecords(List<Product_Review> list,out int record)
        {
            var records = (from product in list orderby product.rating descending select product).Take(3);
            
            foreach (Product_Review product in records)
            {
               
                Console.WriteLine("Productid" + product.productid + " " + "Userid" + product.userid + " " + "Ratings" + product.rating + " " + "Reviews" + product.review + " " + "isLike" + product.isLike);
            }
            record = 23;
        }
        public static void SelectRecordsUsingProductId(List<Product_Review> list)
        {
            var racords = (list.Where(r => r.rating > 3 && (r.productid == 1) || (r.productid == 4) || (r.productid == 9))).ToList();
            foreach (Product_Review product in racords)
            {
                Console.WriteLine("Productid" + product.productid + " " + "Userid" + product.userid + " " + "Ratings" + product.rating + " " + "Reviews" + product.review + " " + "isLike" + product.isLike);
            }
        }
        public static void SelectCountOfRecords(List<Product_Review> list)
        {
            var records = list.GroupBy(p => p.productid).Select(x => new { productid = x.Key, count = x.Count() });
            foreach (var item in records)
            {
                Console.WriteLine("Productid" + item.productid + " " +"Count"+item.count );
            }
        }
        public static void SelectProductidAndReview(List<Product_Review> list)
        {
            var records = list.Select(product => new { productid = product.productid, Review = product.review }).ToList();
            foreach (var item in records)
            {
                Console.WriteLine("Productid" + item.productid + " " + "Review" + item.Review);
            }
        }
        public static void SkipTopFiveRecords(List<Product_Review> list)
        {
            var records = (from product in list orderby product.rating descending select product).Skip(5);
            foreach (Product_Review product in records)
            {
                Console.WriteLine("Productid" + product.productid + " " + "Userid" + product.userid + " " + "Ratings" + product.rating + " " + "Reviews" + product.review + " " + "isLike" + product.isLike);
            }
        }
        public void ProductReviewDataTable(List<Product_Review> list)
        {
            dataTable.Columns.Add("Productid").DataType = typeof(Int32);
            dataTable.Columns.Add("Userid").DataType = typeof(Int32);
            dataTable.Columns.Add("Ratings").DataType=typeof(int);
            dataTable.Columns.Add("Review");
            dataTable.Columns.Add("isLike").DataType = typeof(bool);
            foreach(var item in list)
            {
                dataTable.Rows.Add(item.productid, item.userid, item.rating, item.review, item.isLike);
            }
            var productTable = from products in dataTable.AsEnumerable() select products;
            foreach(DataRow product in productTable)
            {
                Console.WriteLine(product.Field<int>("Productid") + " " + product.Field<int>("Userid") + " " + product.Field<int>("Ratings") + " " + product.Field<string>("Review") + " " + product.Field<bool>("isLike"));
            }
        }
      }
    }
}
