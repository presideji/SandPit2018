using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using RepPCWorkMSTestFramework.ComponentHelper;
using RepPCWorkMSTestFramework.Settings;

namespace RepPCWorkMSTestFramework.TestScripts.MenuButton
{
    [TestClass]
    public class SelectMenuButton
    {
        [TestMethod, TestCategory("SELECT A BUTTON")]

        public void HandleButtons()
        {
            NavigationHelper.NavigateTOURL(ObjectRepository.Config.GetWebsite());

            //IWebElement menuButton = ObjectRepository.Driver.FindElement(By.ClassName("btn-primary"));
            //menuButton.Click();

            //now let us link this to the helper file/code
            Console.WriteLine("Button text is {0}", MenuButtonHelper.GetButtonText(By.ClassName("btn-primary")));
            Console.WriteLine(MenuButtonHelper.IsButtonEnabled(By.ClassName("btn-primary")));
            MenuButtonHelper.SelectMenuButton(By.ClassName("btn-primary"));
        }
    }
}
