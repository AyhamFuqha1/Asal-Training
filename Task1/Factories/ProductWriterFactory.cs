using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Readers;
using Task1.Readers.Interfaces;
using Task1.Readers.Task1.Readers;
using Task1.Writers;
using Task1.Writers.Interfaces;

namespace Task1.Factories
{
    internal class ProductWriterFactory
    {
        public IProductWriter Create(string type)
        {
            if (type == "console")
            {
                return new ConsoleProductWriter();
            }
            else if (type == "csv")
            {
                return new JsonProductWriter();
            }
            throw new ArgumentException("Invalid reader type");
        }
    }
}

