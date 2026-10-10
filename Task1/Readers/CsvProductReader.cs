using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Models;
using Task1.Readers.Interfaces;

namespace Task1.Readers
{
    internal class CsvProductReader : IProductReader
    {
        public List<Product> Read()
        {

            List<Product> products = new List<Product>();
            string[] lines = File.ReadAllLines(
      "C:\\Users\\DELL\\source\\repos\\Task1\\Task1\\product.csv"
  );
            for (int i = 1; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');

                string code = data[0];
                string name = data[1];
                string description = data[2];
                decimal price = decimal.Parse(data[3]);
                int quantity = int.Parse(data[4]);
                products.Add(new Product(0, code, name, description, price, quantity));
            }
            return products;

        }
    }
}
