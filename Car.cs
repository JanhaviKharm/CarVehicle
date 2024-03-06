using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    internal class Car : Vehicle, RoadRules
    {
        public string horn()
        {
            return "Horn ok Please";
        }

        public string speedDown()
        {
            return "Speed limit reached, Speed Down!";
        }

        public string speedUp()
        {
            return "Speed Up Guys";
        }

        public string CarType;
        public int SeatNo;

        public Car() 
        {
            CarType = "Sedan";
            SeatNo = 4;
        }

        public Car(string CarType , int SeatNo )
        { 
            this.CarType = CarType;
            this.SeatNo = SeatNo;
        }

        public Car( string CarType, int SeatNo , int Make , string Model, int Price)
            :base(Make,Model,Price)
        {
            this.CarType = CarType;
            this.SeatNo = SeatNo;
        }
    }
}
