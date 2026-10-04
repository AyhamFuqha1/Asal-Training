using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal static class ProductPrinter
    {
        public static void ShowProducts(IReadOnlyList<Product> Products)
        {
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine($"{"Products",-5} {"Code",-12} {"Name",-20} {"Description",-20} {"Price",-10} {"Qty",-5}");
            Console.WriteLine("--------------------------------------------------------------------------------");

            foreach (Product product in Products)
            {
                Console.WriteLine(
                    $"{product.Id,-5} " +
                    $"{product.ProductCode,-12} " +
                    $"{product.Name,-20} " +
                    $"{product.Description,-20} " +
                    $"{product.Price,-10} " +
                    $"{product.Quantity,-5}"
                );
            }

            Console.WriteLine("--------------------------------------------------------------------------------");
        }

    }
}
