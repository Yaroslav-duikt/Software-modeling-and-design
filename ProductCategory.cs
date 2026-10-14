using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class ProductCategory : IEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int CategoryId { get; set; }

        public ProductCategory(int productId, int categoryId)
        {
            ProductId = productId;
            CategoryId = categoryId;
        }

        public override string ToString()
        {
            return $"{Id} Product:{ProductId} Category:{CategoryId}";
        }
    }
}
