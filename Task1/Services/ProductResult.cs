using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Models;

namespace Task1.Services
{
    internal class ProductResult
    {
        public Product product;
        bool result;
        public string Message;

        public ProductResult(Product product, bool result,string Message)
        {
            this.product = product;
            this.result = result;
            this.Message = Message;
        }
    }
}
