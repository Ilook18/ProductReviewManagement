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

       
    }
}
