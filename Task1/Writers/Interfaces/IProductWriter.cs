using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Models;

namespace Task1.Writers.Interfaces
{
    internal interface IProductWriter
    {
        void Write(IReadOnlyList<Product> products);
    }
}
