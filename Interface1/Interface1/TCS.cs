using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
    public class TCS: GovtRules
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }
        public string Desig { get; set; }

        public int BasicSalary { get; set; }

        public TCS(int empId, string name, string dept, string desig, int basicSalary)
        {
            EmpId = empId;
            Name = name;
            Dept = dept;
            Desig = desig;
            BasicSalary = basicSalary;
        }
       
        public double EmployeePF(double basicSalary)
        {
            double pf=(0.12*basicSalary)+((8.33/100)*basicSalary)+((3.67/100)*basicSalary);
            return pf;
        }

        public string LeaVeDetails()
        {
            string g = "Casusl Leave per month: 1day \n Sick Leave per year: 12days\nPrevilage Leave per year:10days";
            return g;
        }

        public double gratuityAmount(float serviceCompleted, double basicSalary)
        {
            if(serviceCompleted>5 && serviceCompleted<=10)
            {
                return basicSalary;
            }
            else if(serviceCompleted>10&& serviceCompleted<=20)
            {
                return 2 * basicSalary;
            }
            else if(serviceCompleted<5)
            {
                return 0*basicSalary;
            }
            else
            {
                return 3 * basicSalary;
            }
        }


    }

}
