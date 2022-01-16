﻿using System;
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
      }
    }
}
