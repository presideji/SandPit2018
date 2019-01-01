using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using RepPCWorkMSTestFramework.ComponentHelper;
using RepPCWorkMSTestFramework.Settings;

namespace RepPCWorkMSTestFramework.TestScripts.PageNavigation
{
    [TestClass]
    public class TestNavigationPage
    {
        [TestMethod]
        [TestCategory("NEW BROWSER LAUNCH")]
        public void OpenPage()
        {
            NavigationHelper.NavigateTOURL(ObjectRepository.Config.GetWebsite());
            //Console.WriteLine(ObjectRepository.Driver.Title); //let us put"objectRepository.Driver.Title" in window helper
            //it can also be written as below
            //var CurrentPagetitle = ObjectRepository.Driver.Title;
            //Console.WriteLine(CurrentPagetitle);

            //when put in window helper we now have
            Console.WriteLine(WindowHelper.GetPageTitle());

           

        }
    }
}
