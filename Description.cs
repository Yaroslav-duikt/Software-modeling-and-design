using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Description : IEntity
    {
        public int Id {  get; set; }
        public string ProductDescription { get; set; }
        public int ProductId {  get; set; }

        public Description(string productDescription, int productId)
        {
            ProductDescription = productDescription;
            ProductId = productId;
        }

        public override string ToString()
        {
            return $"  Опис: {ProductDescription}";
        }
    }
}
