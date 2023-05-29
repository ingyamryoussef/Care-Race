using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class SportsCar : Car
    {
        //private string tires_type;
        private string extra_features;

        public SportsCar()
        {

        }
       

        public SportsCar(double max_speed,string brand_car,string colour,int seats_no,string motortype,string fuel_type,/*string tires_type,*/string extra_features,double carcost,double constantSpeed) : base(max_speed, brand_car, colour, seats_no, motortype, fuel_type,carcost,constantSpeed)
        {
           // this.tires_type = tires_type;
            this.extra_features = extra_features;
        }

        public override double batterylife()
        {
            double battery_capacity = 10000*2;
            double consumption = double.Parse(Console.ReadLine());


            return battery_capacity * consumption;
        }

        public override double calculate_speed()
        {
            double maxspeed = 1 + constantSpeed;
            if(extra_features=="Speed boost")
            {
                double speed_boosted = 2;
                maxspeed = maxspeed + speed_boosted;
            }

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
