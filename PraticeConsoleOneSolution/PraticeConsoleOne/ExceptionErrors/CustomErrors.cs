using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticeConsoleOne.ExceptionErrors
{
    public class CustomErrors : Exception
    {
        //constructor of custom error
        public CustomErrors(string errorMessage) : base(errorMessage)
        {
            Console.WriteLine("THIS IS FROM A CUSTOM ERROR CLASS");
        }
    }
}
