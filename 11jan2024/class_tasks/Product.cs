using System;
using System.Collections.Generic;
using System.Text;

namespace class_tasks
{
    internal class Product
    {
        public Product(string name)
        {
            Name = name;
        }
        public Product(string name, double price = 10)
        {
            Name = name;
            Price = price;
        }


        public string Name;
        public double Price = 10;
    }
}
