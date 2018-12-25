using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using PCWorkMSTestFramework.Interfaces;

namespace PCWorkMSTestFramework.Setting
{
    //35 creating Object repository. once we create them we will be using get and set to call them
    public class ObjectRepository
    {
        public static IConfig Config { get; set; }
        public static IWebDriver Driver { get; set; }
        //35b let us go back to the base class now
    }
}
