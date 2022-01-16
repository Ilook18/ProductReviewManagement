﻿using System;
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
                Console.WriteLine("Enter your Choice Number to Execute the Program Press- 1-DisplayData, 2-Retrive Data, 3-Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Management.Display(list);
                        break;
                    case 2:
                        Management.SelectTopRatingRecords(list);
                        break;
                    case 3:
                        flag = false;
                        break;
                     }
                }

        }
    }
}