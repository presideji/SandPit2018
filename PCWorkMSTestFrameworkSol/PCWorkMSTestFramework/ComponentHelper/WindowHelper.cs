using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PCWorkMSTestFramework.Setting;

namespace PCWorkMSTestFramework.ComponentHelper
{
    public class WindowHelper
    {
        public static string GetPageTitle()
        {
            return ObjectRepository.Driver.Title;
        }
    }
}
