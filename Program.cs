using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLib;

namespace HRAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            List<Employee> employeesList = new List<Employee>();
            do
            {
                Console.WriteLine("1. Display All employee \n2. Insert Confirm Value \n3. Insert Trainee \n");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                    DisplayAllEmpMethod(employeesList);

                else if (choice == 2)
                    ConfirmEmployeeMethod(employeesList);
                else if (choice == 3)
                    InsertTraineeMethod(employeesList);

                Console.WriteLine("\nDo you want to continue Y/N");
                 ch = Convert.ToChar(Console.ReadLine());
                ch = Char.ToUpper(ch);
            }
            while (ch == 'Y');

         }
        static void DisplayAllEmpMethod(List<Employee> employeesList) 
        {
            if(employeesList.Count==0)
                Console.WriteLine("NO EMPLOYEE.");
            foreach (Employee employee in employeesList)
            {
                Console.WriteLine(employee);
            }
            
        }
        static public int ConfirmEmployeeMethod(List<Employee> employeesList) 
        {
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Address: ");
            string address = Console.ReadLine();

            double basic=0;
            try
            {
                Console.WriteLine("Enter the Basic salary >5000: ");

                 basic = Convert.ToDouble(Console.ReadLine());
                if (basic < 5000)
                    throw new LessSalaryException("salary should be greater then 5000");
             
            }
            catch (LessSalaryException ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
               
            }
            
                Console.WriteLine("Enter Designation: ");
                string designation = Console.ReadLine();
                employeesList.Add(new ConfirmEmployee(name, address, basic, designation));
                return 0;
            
        }
        static public void InsertTraineeMethod(List<Employee> employeesList)
        {

            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Address: ");
            string address = Console.ReadLine();
            Console.WriteLine("Enter No Of Days: ");
            int noOfDays = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter ratePerDays: ");
            int ratePerDays = Convert.ToInt32(Console.ReadLine());
            employeesList.Add(new Trainee(name, address, noOfDays, ratePerDays));


            
        }
    }
}
