using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
    interface GovtRules
    {
        double EmployeePF(double basicSalary);
        string LeaVeDetails();
        double gratuityAmount(float serviceCompleted, double basicSalary);
    }
    internal class Program
    {

       


        static void Main(string[] args)
        {
            TCS t = new TCS(12, "DER", "DELIVERY", "ASS", 2000);
            string r=t.LeaVeDetails();
            Console.WriteLine(r);

            double v = t.gratuityAmount(20f, 2000);
            Console.WriteLine(v);
                
        }
    }
}
