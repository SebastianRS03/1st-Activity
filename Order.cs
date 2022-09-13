using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1st_Activity
{
    internal class Order
    {
        private readonly int orderID;
        public Product[] products;
        private static int contadorOrdenes;
        public int productCounter;
        private static readonly int MAX_PRODUCTS = 10;

        public Order()
        {
            this.orderID = ++Order.contadorOrdenes;
            this.products = new Product[Order.MAX_PRODUCTS];
        }

        public void addProduct(Product product)
        {
            if (this.productCounter < Order.MAX_PRODUCTS)
            {
                Boolean repeated = isRepeated(product);
                if (repeated == false)
                {
                    this.products[this.productCounter] = product;
                    this.productCounter++;
                }  
            }
            else
            {
                Console.WriteLine("You can't add more products to the order");
            }
        }

        public Boolean isRepeated(Product product)
        {
            if(this.products != null)
            {
                string title = product.title;
                int quantity = product.quantity;
                for (int i = 0; i < this.productCounter; i++)
                {
                    if (title == products[i].title)
                    {
                        products[i].quantity = products[i].quantity + quantity;
                        return true;
                    }
                    
                }
            }
            return false;
        }

        public void showOrder()
        {
            decimal total = 0;
            Console.WriteLine("Order ID: " + this.orderID);
            Console.WriteLine(" ");
            Console.WriteLine("Products of the order: ");
            for (int i = 0; i < this.productCounter; i++)
            {
                Console.WriteLine("Product: " + products[i].title);
                Console.WriteLine("Product ID: " + products[i].productID);
                Console.WriteLine("Price: " + products[i].price);
                Console.WriteLine("Quantity: " + products[i].quantity);
                Console.WriteLine("Discount: " + products[i].discount);
                products[i].total = (products[i].price * products[i].quantity) - products[i].discount;
                Console.WriteLine("Product total: " + products[i].total);
                total = total + products[i].total;
                Console.WriteLine(" ");

            }
            Console.WriteLine("Total of the order: " + total);
        }
    }
}
