using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2

{
    class Van : Car
    {

        public Van()
        {

        }
        public Van(double max_speed, string brand_car, string colour, int seats_no, string motortype, string fuel_type, double carcost,double constantSpeed) : base(max_speed, brand_car, colour, seats_no, motortype, fuel_type, carcost,constantSpeed)
        {

        }

        public override double batterylife()
        {
            double battery_capacity = 10000*10;
            double consumption = double.Parse(Console.ReadLine());


            return battery_capacity * consumption;
        }

        public override double calculate_speed()
        {
            double maxspeed = 0.5 + constantSpeed;

            if (fuel_type == "Methanol")
            {
                maxspeed = maxspeed + 1.5;
            }

            else if (fuel_type == "Nitrous")
            {
                maxspeed = maxspeed + 1.75;
            }

            else if (fuel_type == "Leaded Gasoline")
            {
                maxspeed = maxspeed + 2;
            }

            return maxspeed;

        }

        public override double weight_car(double power, double powerperpound)
        {
            return power / powerperpound;
        }


    }
}
