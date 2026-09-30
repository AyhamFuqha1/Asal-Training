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
        private List<Product> Products;
        private int ID;
        private Product NewProduct;
        public ProductManger()
        {
            Products = new List<Product>();
            ID = 0;
        }
        public string addProduct(string ProductCode, string name, string Description, decimal Price, int Quantity)
        {
           
            if (!CheckCode(ProductCode,out string ProductMessage))
            {
                return ProductMessage;
            }
            NewProduct = new Product(ID, ProductCode);

            if (!NewProduct.SetName(name, out string NameMessage))
            {
                return NameMessage;
            }

            if (!NewProduct.SetDescription(Description, out string DescrptionMessage))
            {
                return DescrptionMessage;
            }

            if (!NewProduct.SetPrice(Price, out string priceMessage))
            {
                return priceMessage;
            }

            if (!NewProduct.SetQuantity(Quantity, out string quantityMessage))
            {
                return quantityMessage;
            }
            ID++;
            Products.Add(NewProduct);
            return "Product added successfully.";
        }

        public Boolean CheckCode(string ProductCode ,out string message)
        {
            if(ProductCode.Length == 0)
            {
                message = "ProductCode is Reqired";
            }
            foreach (Product product in Products)
            {
                if (product.ProductCode == ProductCode)
                {
                    message = "Product code is already in use.";
                    return false;
                }
            }
            message = "product is valProducts";
            return true;
        }


        //-----------------------EEROR-------------------//
        private string ERROR(string error)
        {
            return "Value in " + error + " not valProducts";
        }

        public void ShowProducts()
        {
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine($"{"Products",-5} {"Code",-12} {"Name",-20} {"Description",-20} {"Price",-10} {"Qty",-5}");
            Console.WriteLine("--------------------------------------------------------------------------------");

            foreach (Product product in Products)
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
