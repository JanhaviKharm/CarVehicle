using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    internal class Vehicle
    {
        public int make;
        public string model;
        public int price;

        public int getMake() { 
            return make;
        }

        public int getPrice()
        {
            return price;
        }

        public void setPrice( int price)
        {
            this.price= price;
        }

        public string getModel()
        {
            return model;
        }

        public Vehicle(int make, string model)
        {
            this.make = make;
            this.model = model;
        }

        public Vehicle(int make, string model, int price): this(make,model)
        {
            this.price=price;
           
        }

        public  Vehicle()
        {
            this.make = 0000;
            this.model = "xyz";
        }

        




    }
}
