using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
    public class Accenture: GovtRules
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }
        public string Desig { get; set; }

        public int BasicSalary { get; set; }

        public Accenture(int empId, string name, string dept, string desig, int basicSalary)
        {
            EmpId = empId;
            Name = name;
            Dept = dept;
            Desig = desig;
            BasicSalary = basicSalary;
        }

        public double EmployeePF(double basicSalary)
        {
            double pf = (0.12 * basicSalary) + (0.12 * basicSalary);
            return pf;
        }
        public string LeaVeDetails()
        {
            string g = "Casusl Leave per month: 2day \n Sick Leave per year: 5days  \nPrevilage Leave per year:5days";
            return g;
        }

        public double gratuityAmount(float serviceCompleted, double basicSalary)
        {
            return 0;
        }
    }
}
