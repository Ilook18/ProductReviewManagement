using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;

namespace Product_Review_Management
{
   public class Management
    {
        public static void Display(List<Product_Review> list)
        {
            foreach (Product_Review product in list)
            {
                Console.WriteLine("Productid:" + product.productid + "UserId:" + product.userid + "Rating:" + product.rating
                    + "Review" + product.review + "isLike" + product.isLike);
            }
        }

        public static void SelectTopRatingRecords(List<Product_Review> list)
        {
            var records = (from product in list orderby product.rating descending select product).Take(3);

            foreach (Product_Review product in records)
            {
                Console.WriteLine("Productid" + product.productid + " " + "Userid" + product.userid + " " + "Ratings" + product.rating + " " + "Reviews" + product.review + " " + "isLike" + product.isLike);
            }
        }
        
    }
}
