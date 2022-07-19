using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStrength
{
    internal class Program
    {
        


        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the password");
            string psw = Console.ReadLine();
            int count = 0;
            

            bool isLength = CheckLength(psw);
            if (isLength==false)
                Console.WriteLine("Password Length is must be atleats 6 character ");
            else { 
            bool isLetter = CheckLetter(psw);
                if (isLetter == true)
                    ++count;
            bool isDigit = CheckDigit(psw);
                if(isDigit==true)
                    ++count; 

            bool symbol = CheckSymbol(psw); 
                if(symbol==true)
                    ++count;

                if (count == 3)
                    Console.WriteLine("Strong Password");
                else if (count == 2)
                    Console.WriteLine("Weak Password");
                else
                    Console.WriteLine("very Weak Password");
                

            
            }



        }
        static bool CheckLength(string psw) 
        {
            if(psw.Length>=6)
                return true;
              return false;
            
        }
        static bool CheckLetter(string psw)
        {
            foreach(char ch in psw)
            {
                if((ch>='a' && ch<='z' )||(ch>'A' && ch<='Z'))
                    return true;
            }
            return false;
        }

        static bool CheckDigit(string psw)
        {
            foreach (char ch in psw)
            {
                if (ch >= '0' && ch <= '9')
                    return true;
            }
            return false;
        }
        static bool CheckSymbol(string psw)
        {
            foreach (char ch in psw)
            {
                if(ch=='@' || ch=='#' || ch=='$' || ch=='%' || ch=='&')
                    return true;
            }
            return false;
        }


    }
}
