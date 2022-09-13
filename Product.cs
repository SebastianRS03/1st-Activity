using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1st_Activity
{
    internal class Product
    {
        public int productID;
        public static int productCounter;
        public decimal price;
        public int quantity;
        public string title;
        private string description;
        public decimal discount;
        public decimal total;

        public Product(decimal price, int quantity, string title, string description, decimal discount)
        {
            this.productID = ++Product.productCounter;
            this.price = price;
            this.quantity = quantity;
            this.title = title;
            this.description = description;
            this.discount = discount;
            this.total = 0;
        }
    }
}
