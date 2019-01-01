using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepPCWorkMSTestFramework.Settings;

namespace RepPCWorkMSTestFramework.ComponentHelper
{
   public class WindowHelper
    {
       public static string GetPageTitle()
       {
           return ObjectRepository.Driver.Title;
       }
    }
}
