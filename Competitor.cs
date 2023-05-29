using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class Competitor : Person
    {
        Car car1 = new StreetCar();
        Car car2 = new SportsCar();
        Car car3 = new IndyCar();
        Car car4 = new Van();

        string fileName = @"C:\Users\lapcell\Desktop\Advanced Programming Project\Database.txt";


    }
}
