using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class Race : Person
    {
        private DateTime setting = new DateTime();
        public Race()
        { }
  
        public Race(string name, int age, string job, DateTime expir_licence,double budget, int races_entered, int races_won, int ranking, string skills, DateTime setting) : base(name, age, job, expir_licence, budget, races_entered, races_won, ranking, skills)
        {
            this.setting = setting;
        }

        public bool expirylicense()

        {
            if (expir_license.Date <= setting)
            {
                return false;
            }
            else return true;
        }
    }
}
