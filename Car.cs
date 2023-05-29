using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    abstract class Car
    {
       
        protected string brand_car;
        protected string colour;
        protected int seats_no;
        protected string fuel_type;
        protected double carcost;
        public static double constantSpeed=20;
        public Car() { }

        public Car( string brand_car, string colour, int seats_no, string fuel_type, double carcost, double constantSpeed)
        {
            
            this.brand_car = brand_car;
            this.colour = colour;
            this.seats_no = seats_no;
            this.fuel_type = fuel_type;
            this.carcost = carcost;
         
        }

        public string Colour {
           get 
            {
                return colour;
            }

            set
            {
                colour = value;
            }

            }
        public double CarCost
        {
            get
            {
                return carcost;
            }
            set
            {
                carcost = value;
            }
        }

        public abstract double batterylife();

        public abstract double weight_car(double power, double powerperpound);
        public abstract double calculate_speed();

        public virtual bool Check()
        {
            return false;
        }
        

        public double cost()
        {
            double cost = carcost;
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
