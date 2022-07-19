using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public abstract class Employee
    {
        string name;
        string address;
        public string Name 
        {
            get { return name; }    
            set { name = value; }
        }
        public string Address 
        {
            get { return address; }
            set { address = value; }
        }
        public Employee() { }
        public Employee(string name,string address) 
        {
            this.name = name;   
            this.address = address;
        }

        public abstract double CalculateSalary();
    }
}
