using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{


    internal class Product
    {
        public int Id { get; private set; }
        public string ProductCode { get; private set; }
        public string Name { get; private set; }
        public string? Description { get; private set; }
        public decimal Price { get; private set; }
        public int Quantity { get; private set; }

        public Product(
            int id,
            string productCode,
            string name,
            string? description,
            decimal price,
            int quantity)
        {
            Id = id;
            ProductCode = productCode;
            Name = name;
            Description = description;
            Price = price;
            Quantity = quantity;
        }
    }
}


