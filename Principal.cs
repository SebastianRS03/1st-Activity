using _1st_Activity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Activities
{
    internal class Principal
    {
        private static void Main(string[] args)
        {
            Product milk = new Product(20, 2, "Milk", "De-lacted", 15);
            Order order1 = new Order();
            order1.addProduct(milk);
            Product milk2 = new Product(20, 4, "Milk", "Lacted", 15);
            order1.addProduct(milk2);
            Product chips = new Product(15, 1, "Chips", "Salty", 0);
            order1.addProduct(chips);
            order1.showOrder();
            
        }
    }
}
