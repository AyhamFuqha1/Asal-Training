using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Task1.Models;

namespace Task1.Readers
{
    using global::Task1.Readers.Interfaces;
    using System;

    namespace Task1.Readers
    {
        internal class ConsoleProductReader : IProductReader
        {
            public List<Product> Read()
            {
                Console.Write("Code: ");
                string code = Console.ReadLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Description: ");
                string description = Console.ReadLine();

                Console.Write("Price: ");
                decimal price = decimal.Parse(Console.ReadLine());

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(
                    0,
                    code,
                    name,
                    description,
                    price,
                    quantity
                );

                return new List<Product> { product };
            }
        }
    }
}
