using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
           
            if (!CheckCode(ProductCode,out string ProductMessage))
            {
                return ProductMessage;
            }
            newProduct = new Product(id, ProductCode);

            if (!newProduct.setName(name, out string NameMessage))
            {
                return NameMessage;
            }

            if (!newProduct.setDescription(Description, out string DescrptionMessage))
            {
                return DescrptionMessage;
            }

            if (!newProduct.setPrice(Price, out string priceMessage))
            {
                return priceMessage;
            }

            if (!newProduct.setQuantity(Quantity, out string quantityMessage))
            {
                return quantityMessage;
            }
            id++;
            products.Add(newProduct);
            return "Product added successfully.";
        }

        public Boolean CheckCode(string ProductCode ,out string message)
        {
            if(ProductCode.Length == 0)
            {
                message = "ProductCode is Reqired";
            }
            foreach (Product product in products)
            {
                if (product.ProductCode == ProductCode)
                {
                    message = "Product code is already in use.";
                    return false;
                }
            }
            message = "product is valid";
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
