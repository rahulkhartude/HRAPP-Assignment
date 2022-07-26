using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
   public  class Trainee:Employee
    {
        int noOfDays;
        double ratePerDays;
        int traineeNo = 0; 
            //= ConfirmEmployee.ObjNo;

        public override string ToString()
        {
            return $"SrNo:{traineeNo}  TName:{Name} Address:{Address} NoOfDays: {noOfDays}  RatePerDays: {ratePerDays}";
        }
        public int NoOfDays 
        {
            get { return noOfDays; }
            set { noOfDays = value; }   
        }
        public double RatePerDays   
        {
            get { return ratePerDays; } 
            set { ratePerDays = value; } 
        }
        public Trainee ()
        {

        }
        public Trainee(string name,string address,int noOfDays,double ratePerDays):base(name,address)
        {
            this.noOfDays = noOfDays;   
            this.ratePerDays = ratePerDays;
            /*ConfirmEmployee.ObjNo++;
            traineeNo = ConfirmEmployee.ObjNo*/;
            objNo++;
            traineeNo = objNo;
        }
        public override double CalculateSalary()
        {
            return noOfDays * ratePerDays;  
        }
    }
}
