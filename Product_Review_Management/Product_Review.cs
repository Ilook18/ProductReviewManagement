using System;
using System.Collections.Generic;
using System.Text;

namespace Product_Review_Management
{
    public class Product_Review
    {
        public int productid { get; set; }
        public int userid { get; set; }
        public int rating { get; set; }
        public string review { get; set; }
        public bool isLike { get; set; }
    }
}
