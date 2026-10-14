using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Category : IEntity
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public Category(string categoryName)
        {
            CategoryName = categoryName;
        }

        public override string ToString()
        {
            return $"{Id} {CategoryName}";
        }
    }
}
