using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class IndyCar : Car
    {
        public bool extra_features;

        
        public IndyCar()
        { }
        public IndyCar( string brand_car, string colour, int seats_no,  string fuel_type, bool extra_features, double carcost, double constantSpeed) : base( brand_car, colour, seats_no, fuel_type, carcost, constantSpeed)
        {
            this.extra_features = extra_features;
        }


        
        public override double batterylife()
        {
            double battery_capacity = 10000 * 5;
            double consumption = double.Parse(Console.ReadLine());


            return battery_capacity * consumption; ;
        }
        public override bool Check ()
        {
            return extra_features;
            
        }
        public override double calculate_speed()
        {
            double maxspeed = 20 + constantSpeed;
            
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
