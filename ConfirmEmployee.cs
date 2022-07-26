using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public class ConfirmEmployee:Employee
    {
        double basic;
        string designation;
        
       // private static int objNo=0;
        public static int ObjNo { get; set; }

         int empNo = objNo;
        public int EmpNO { get; set; }
        public override string ToString()
        {
            return $"SrNo:{empNo} Name:{Name} Address:{Address}  basic: {basic}  Designation:{designation} ";
        }
        public double Basic 
        {
            get { return basic; }   
            set { basic = value; }  
        }
        public string Designation 
        {
            get { return designation; } 
            set { designation = value; }    
        }

      public  ConfirmEmployee() { }
   public   ConfirmEmployee(string name,string address,double basic,string designation ):base(name,address) 
        {
            if (basic < 5000) 
            {
                throw new LessSalaryException("Salary is less then 5000 exception occured...");
            }
            this.basic = basic; 
            this.designation = designation;
            objNo++;
            empNo = objNo;
        }

        public override double CalculateSalary()
        {
            double netSalary = 0;
            double hra = 0;
            double conv = 0;
            double pf = 0;

            if (basic >= 30000)
            {
                hra = basic * (30.0 / 100);
                conv = basic * (30.0 / 100);
                pf = basic * (10.0 / 100);
            }
            else if (basic >= 20000)
            {

                hra = basic * (20.0 / 100);
                conv = basic * (20.0 / 100);
                pf = basic * (10.0 / 100);
            }

            else 
            {
                hra = basic * (10.0 / 100);
                conv = basic * (10.0 / 100);
                pf = basic * (10.0/ 100);
            }
            netSalary=basic+hra+conv-pf;   
            return netSalary;
        }

    }
}
