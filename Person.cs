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
            protected DateTime expir_license = new DateTime();
            private double budget;
            private int races_entered;
            private int races_won;
            private int ranking;
            private string skills;

            public Person()
            { }
            public Person(string name, int age, string job, DateTime expir_license, double budget, int races_entered, int races_won, int ranking, string skills)
            {
                this.name = name;
                this.age = age;
                this.job = job;
                this.expir_license = expir_license;
                this.budget = budget;
                this.races_entered = races_entered;
                 this.races_won = races_won;
                this.ranking = ranking;
                this.skills = skills;

            }

        public bool age_validation()
        {
            if (age < 21)
            {
                return false;
            }
            else return true;

        }

        public bool racesenterd_validation()
        {
            if (races_entered < 0)
            {
                return false;
            }
            else return true;

        }

        public bool raceswon_validation()
        {
            if (races_won < 0)
            {
                return false;
            }
            else return true;

        }

        public bool ranking_validation()
        {
            if (ranking < 0)
            {
                return false;
            }
            else return true;

        }
    }
    }
