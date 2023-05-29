using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class Person
    {
        private string name;
        private int age;
        private string job;
        DateTime expir_license = new DateTime();
        private double budget;

        private int races_entered;
        private int races_won;
        private int ranking;
        private string skills;




        public Person()
        {

        }
        public Person(string name, int age, string job,DateTime expir_license,double budget, int races_entered,int races_won,int ranking,string skills)
        {
            this.name = name;
            if (age >= 21)
                this.age = age;
            this.job = job;
            this.expir_license = expir_license;
            this.budget = budget;

            if (races_entered >= 0)
                this.races_entered = races_entered;
            if (races_won >= 0)
                this.races_won = races_won;
            if (ranking >= 0)
                this.ranking = ranking;
            this.skills = skills;

        }

        //public void expirylicense(DateTime expir_license)
      //{
       //    if (expir_license.Day > DateTime.Now)
        //        Console.WriteLine("License is expired,can't enter a race");
      //}

       
    }
}
