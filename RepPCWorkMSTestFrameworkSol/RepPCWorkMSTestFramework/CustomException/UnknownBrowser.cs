using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepPCWorkMSTestFramework.CustomException
{
    public class UnknownBrowser :Exception
    {
        public UnknownBrowser(string message) : base(message)
        {
            
        }
    }
}
