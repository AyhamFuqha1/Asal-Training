using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Services.Interfaces
{
    internal interface IProductService
    {
        List<ProductResult> AddProduct(string type);
        void ShowProducts(string type);
    }
}
