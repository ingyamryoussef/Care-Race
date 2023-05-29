using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class Race : Person
    {
        private string place_race;
        private DateTime setting = new DateTime();
       


        public Race()
        {

        }
        public Race(string name,int age,string job,DateTime expir_licence, string place_race, DateTime setting,double budget,int races_entered,int races_won,int ranking,string skills) : base(name, age, job, expir_licence,budget,races_entered,races_won,ranking,skills)
        {
            this.place_race = place_race;
            this.setting = setting;
            
        }

        public void expirylicense(DateTime expirylicense, DateTime racetime)
                                                              
        {
            if (expirylicense.Date <= racetime.Date)
            {
                Console.WriteLine("Illegal participation,License is expired");
            }
        }
    }









     
}
