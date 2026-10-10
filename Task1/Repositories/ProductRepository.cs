using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Models;
using Task1.Repositories.interfaces;

namespace Task1.Repositories
{
    internal class ProductRepository: IProductRepository
    {
        private List<Product> Products { get; set; }
        private int ID;
        public ProductRepository()
        {
            Products = new List<Product>();
            ID = 0;
        }
        public void AddProduct(Product product)
        {
            product.SetId(ID);
            ID++;
            Products.Add(product);
        }

        public List<Product> IReadOnlyList()
        {
            return Products;
        } 

        public int GetID()
        {
            return ID++;
        }

        public bool CheckCode(string productCode, out string message)
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
    }
}
