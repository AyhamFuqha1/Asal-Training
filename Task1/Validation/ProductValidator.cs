using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Models;
using Task1.Validation.Interfaces;

namespace Task1.Application.Validation
{
    internal class ProductValidator : IProductValidator
    {

        public bool Validate(Product product, out string message)
        {
            if (!ValidateCode(product.ProductCode, out message))
                return false;

            if (!ValidateName(product.Name, out message))
                return false;

            if (!ValidateDescription(product.Description, out message))
                return false;

            if (!ValidatePrice(product.Price, out message))
                return false;

            if (!ValidateQuantity(product.Quantity, out message))
                return false;

            
            message = "Product is valid.";
            return true;
        }

        public bool ValidateCode(string code, out string message)
        {
            if (string.IsNullOrWhiteSpace(code))
            {
                message = "ProductCode is Reqired";
                return false;
            }
            message = "Code Is Valid";
            return true;

        }

        public bool ValidateName(string name, out string message)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                message = "Name is required";
                return false;
            }
            message = "Name is Valid";
            return true;

        }
        public bool ValidateDescription(string description, out string message)
        {
            if (description != null && description.Length > 500)
            {
                message = "Description must not exceed 500 characters.";
                return false;
            }
            message = "Description is valid.";
            return true;

        }
        public bool ValidatePrice(decimal price, out string message)
        {
            if (price <= 0)
            {
                message = "Price must be greater than 0.";
                return false;
            }
            message = "price is valid";
            return true;

        }
        public bool ValidateQuantity(int quantity, out string message)
        {
            if (quantity < 0)
            {
                message = "Quantity must be greater than or equal to 0.";
                return false;
            }
            message = "Quantity is valid.";
            return true;
        }
    }
}
