using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Models;
using Task1.Writers.Interfaces;

namespace Task1.Writers
{
    internal class ConsoleProductWriter :  IProductWriter
    {
        public void Write(IReadOnlyList<Product> products)
        {
            foreach (Product product in products)
            {
                Console.WriteLine($"ID: {product.Id}");
                Console.WriteLine($"Code: {product.ProductCode}");
                Console.WriteLine($"Name: {product.Name}");
                Console.WriteLine($"Description: {product.Description}");
                Console.WriteLine($"Price: {product.Price}");
                Console.WriteLine($"Quantity: {product.Quantity}");

                Console.WriteLine("-----------------------------");
            }
        }

    }
}
