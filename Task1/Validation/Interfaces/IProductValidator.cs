using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Models;

namespace Task1.Validation.Interfaces
{
    internal interface IProductValidator
    {
        bool Validate(Product product,out string message);
        bool ValidateCode(string code, out string message);

        bool ValidateName(string name, out string message);

        bool ValidateDescription(string description, out string message);

        bool ValidatePrice(decimal price, out string message);

        bool ValidateQuantity(int quantity, out string message);
    }
}
