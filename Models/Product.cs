using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionStructure.Models
{
    internal class Product
    {
        private int _id;
        private string _name;
        private double _price;
        private double _discountPercent;
        private double _priceAfterDiscount;

        private const int minDiscount = 20;
        private const int maxDiscount = 40;

        //public Product()
        //{
        //    Console.WriteLine("Welcome to Product Class");
        //}

        public Product(string name, int id,  double price, double discountPercent)
        {
            Id = id;
            Name = name;
            Price = price;
            DiscountPercent = discountPercent;
           
        }

        public int Id
        {
            set 
            {  
                _id = value;

            }
            get { return _id; } 


        }
        public string Name { set { _name = value; } get { return _name; } }
        public double DiscountPercent {
            set
            {
                if (value > maxDiscount)
                    _discountPercent = maxDiscount;
                else if (value < minDiscount)
                    _discountPercent = minDiscount;
                else
                    _discountPercent = value;
                          } 
            get { return _discountPercent; }
        }
        public double Price { set { _price = value; } get { return _price; } }


        public double CalculatePriceAfterDiscount()
        {


            _priceAfterDiscount = _price - (_price * _discountPercent / 100);
            return _priceAfterDiscount;
            
            
        }

        

    }
}
