using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2TylerTempleton
{
   
    class Employee
    {
        

        public String name { get; set; }
        public int hours_Worked { get; set; }
        public int hourly_Wage { get; set; }

        
 

       public Employee(String name, int hours_Worked, int hourly_Wage) {
            this.name = name;
            this.hours_Worked = hours_Worked;
            this.hourly_Wage = hourly_Wage;
        }

        public Employee()
        {
        }
    }
}
