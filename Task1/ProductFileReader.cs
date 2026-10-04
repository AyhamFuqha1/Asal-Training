using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class ProductFileReader
    {
        public static void ReadProducts(string filePath,ProductManger productManger)
        {
           

            string[] lines = File.ReadAllLines(filePath);
            for (int i = 1; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');

                string code = data[0];
                string name = data[1];
                string description = data[2];
                decimal price = decimal.Parse(data[3]);
                int quantity = int.Parse(data[4]);

                string message=productManger.AddProduct(code, name, description, price, quantity);
                Console.WriteLine(message);
                
            }

        }
    }
}
