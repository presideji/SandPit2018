using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCWorkMSTestFramework.CustomException
{
    //39 - let us creat a class in "customException"
    public class UnknownBrowser : Exception
    {
        public UnknownBrowser(string message) : base(message) //40 let us go back to the "Baseclass"
        {
            
        }
    }
}
