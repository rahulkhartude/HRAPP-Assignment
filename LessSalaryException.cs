using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public class LessSalaryException:Exception
    {
        public LessSalaryException(string msg):base(msg)
        {

        }


    }
}
