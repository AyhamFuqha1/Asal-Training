using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Task1.Models;
using Task1.Writers.Interfaces;

namespace Task1.Writers
{
    internal class JsonProductWriter : IProductWriter
    {
        private readonly string filePath = "products.jsonl";

        public void Write(IReadOnlyList<Product> products)
        {
            foreach (Product product in products)
            {
                string json = JsonSerializer.Serialize(product);

                File.AppendAllText(
                    filePath,
                    json + Environment.NewLine
                );
            }
        }
    }
}
