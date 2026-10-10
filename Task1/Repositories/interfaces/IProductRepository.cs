using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Models;

namespace Task1.Repositories.interfaces
{
    internal interface IProductRepository
    {
        public void AddProduct(Product product);
        public List<Product> IReadOnlyList();
        public int GetID();
        public bool CheckCode(string productCode, out string message);
    }
}
