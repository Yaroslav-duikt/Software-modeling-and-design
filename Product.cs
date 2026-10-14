using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Product : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string  name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
        public override string ToString()
        {
            return $"{Id} {Name} {Price}";
        }
    }
}
