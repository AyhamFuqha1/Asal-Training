using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class ProductManger
    {
        private List<Product> products;
        private int id;
        private Product newProduct;
        public ProductManger()
        {
            products = new List<Product>();
            id = 0;
        }
        public string addProduct(string ProductCode, string name, string Description, decimal Price, int Quantity)
        {
            Boolean checkCode = CheckCode(ProductCode);
            if (!checkCode)
            {
                Console.WriteLine("Error: Product code "+ProductCode);
            }
            newProduct = new Product(id, ProductCode, name);
            if (!newProduct.setDescription(Description)) { return ERROR("description"); }
            if (!newProduct.setPrice(Price)) { return ERROR("Price"); }
            if (!newProduct.setQuantity(Quantity)) { return ERROR("Quantity"); }
            id++;
            products.Add(newProduct);
            return "Seccesful to add Product";
        }

        public Boolean CheckCode(string ProductCode)
        {
            foreach (Product product in products)
            {
                if (product.ProductCode == ProductCode)
                {
                    return false;
                }
            }
            return true;
        }

        //-----------------------EEROR-------------------//
        private string ERROR(string error)
        {
            return "Value in " + error + " not valid";
        }

        public void ShowProducts()
        {
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine($"{"ID",-5} {"Code",-12} {"Name",-20} {"Description",-20} {"Price",-10} {"Qty",-5}");
            Console.WriteLine("--------------------------------------------------------------------------------");

            foreach (Product product in products)
            {
                Console.WriteLine(
                    $"{product.ID,-5} " +
                    $"{product.ProductCode,-12} " +
                    $"{product.Name,-20} " +
                    $"{product.Description,-20} " +
                    $"{product.Price,-10} " +
                    $"{product.Quantitiy,-5}"
                );
            }

            Console.WriteLine("--------------------------------------------------------------------------------");
        }


    }
}
