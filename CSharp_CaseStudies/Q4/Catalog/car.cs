using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog
{
    public class car
    {
        private string make;
        public string Make
        {
            set { make = value; }
            get { return make; }

        }
        private string model;


        public string Model
        {
            set { model = value; }
            get { return model; }

        }
        private int year;


        public int Year
        {
            set { year = value; }
            get { return year; }

        }
        private double salePrice;


        public double SalePrice
        {
            set { salePrice = value; }
            get { return salePrice; }

        }
        public car() { }

        public car(string make, string model, int year, double salePrice)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.salePrice = salePrice;
        }


    }
}
