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
        public Product(int id, string ProductCode, string name)
        {
            this.ID = id;
            this.ProductCode = ProductCode;
            this.Name = name;
        }



        //------------------Descrption-----------------//
        public Boolean setDescription(string description)
        {
            if (description.Length > 500)
            {
                return false;
            }
            this.Description = description;
            return true;
        }
        public string getDescripton()
        {
            return this.Description;
        }



        //--------------------Price---------------------//
        public Boolean setPrice(decimal Price)
        {
            if (Price <= 0)
            {
                return false;
            }
            this.Price = Price;
            return true;
        }

        public decimal? getPrice()
        {
            return this.Price;
        }

        //--------------------Quantity------------------//
        public Boolean setQuantity(int Quantity)
        {
            if (Quantity < 0)
            {
                return false;
            }
            this.Quantitiy = Quantity;
            return true;
        }

        public int? getQuantity()
        {
            return this.Quantitiy;
        }




    }
}
