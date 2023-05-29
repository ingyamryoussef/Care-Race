using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
   abstract class Car
    {
        protected double max_speed;
        protected string brand_car;
        protected string colour;
        protected int seats_no;
        protected string motortype;
        protected string fuel_type;
        protected double carcost;
        protected double constantSpeed;


        public Car()
        {

        }

        public Car(double max_speed,string brand_car,string colour,int seats_no,string motortype,string fuel_type,double carcost, double constantSpeed)
        {
            this.max_speed = max_speed;
            this.brand_car = brand_car;
            this.colour = colour;
            this.seats_no = seats_no;
            this.motortype = motortype;
            this.fuel_type = fuel_type;
            this.carcost = carcost;
            this.constantSpeed = constantSpeed;
        }

        //public abstract double motorefficiency(double load,double inputpower,double outputpower);

        public abstract double batterylife();

        public abstract double weight_car(double power, double powerperpound);

        //public abstract double no_of_turns_motor(double frequency);

        public abstract double calculate_speed();

        public  double cost()
        {
            double cost = 0;
            if (fuel_type == "Ethanol")
            {
                cost = cost + 4;
            }

            if (fuel_type == "Methanol")
            {
                cost = cost + 10;
            }

            else if (fuel_type == "Nitrous")
            {
                cost = cost + 15;
            }

            else if (fuel_type == "Leaded Gasoline")
            {
                cost = cost + 20;
            }
            return cost;
        }

    }
}
