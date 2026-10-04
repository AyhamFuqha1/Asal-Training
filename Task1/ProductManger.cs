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
        private List<Product> Products { get; set; }
        private int ID;
        public ProductManger()
        {
            Products = new List<Product>();
            ID = 0;
        }
        public string AddProduct(string productCode, string name, string description, decimal price, int quantity)
        {

            if (!ProductValidator.ValidateCode(productCode, out string codeMessage))
            {
                return codeMessage;
            }


            if (!CheckCode(productCode,out string productMessage))
            {
                return productMessage;
            }


            if (!ProductValidator.ValidateName(name, out string nameMessage))
            {
                return nameMessage;
            }

            if (!ProductValidator.ValidateDescription(description, out string descriptionMessage))
            {
                return descriptionMessage;
            }

            if (!ProductValidator.ValidatePrice(price, out string priceMessage))
            {
                return priceMessage;
            }

            if (!ProductValidator.ValidateQuantity(quantity, out string quantityMessage))
            {
                return quantityMessage;
            }

            Product NewProduct = new Product(ID, productCode,name,description,price,quantity);
            ID++;
            Products.Add(NewProduct);
            return "Product added successfully.";
        }

        public bool CheckCode(string productCode ,out string message)
        {
            foreach (Product product in Products)
            {
                if (product.ProductCode == productCode)
                {
                    message = "Product code is already in use.";
                    return false;
                }
            }
            message = "Product code is valid.";
            return true;
        }

        public IReadOnlyList<Product> GetProducts() { 
          return Products;
        }


   
   

    }
}
