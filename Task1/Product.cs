using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{

    internal class Product
    {
        public int ID { get; set; }
        public  string ProductCode { get; set; }
        public string Name { get; set; }
        public string? Description;
        public decimal? Price;
        public int? Quantitiy;



        //-------------------Product------------------//
        public Product(int id, string ProductCode)
        {
            this.ID = id;
            this.ProductCode = ProductCode;
          
        }

       public Boolean setName(string name, out string message)
        {
            if(name.Length == 0)
            {
                message="Name is requird";
                return false;
            }
            message = "Name is Valid";
            return true;
        }

        //------------------Descrption-----------------//
        public Boolean setDescription(string description , out string message)
        {
            if (description.Length > 500)
            {
                message = "Description must not exceed 500 characters.";
                return false;
            }
            this.Description = description;
            message = "Description is valid.";
            return true;
        }



        public string getDescripton()
        {
            return this.Description;
        }



        //--------------------Price---------------------//
        public Boolean setPrice(decimal Price, out string message)
        {
            if (Price <= 0)
            {
                message = "Price must be greater than 0.";
                return false;
            }
            message = "price is valid";
            this.Price = Price;
            return true;
        }

        public decimal? getPrice()
        {
            return this.Price;
        }

        //--------------------Quantity------------------//
        public Boolean setQuantity(int Quantity, out string message)
        {
            if (Quantity < 0)
            {
                message = "Quantity must be greater than or equal to 0.";
                return false;
            }
            this.Quantitiy = Quantity;
            message = "Quantity is valid.";
            return true;
        }

        public int? getQuantity()
        {
            return this.Quantitiy;
        }




    }
}
