using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Readers;
using Task1.Readers.Interfaces;
using Task1.Readers.Task1.Readers;

namespace Task1.Factories
{
    internal class ProductReaderFactory
    {
       public IProductReader Create(string type) {
         if(type == "console")
            {
                return new ConsoleProductReader();
            }
         else if(type == "csv")
            {
                return new CsvProductReader();
                
            }
            throw new ArgumentException("Invalid reader type");
        }
    }
}
