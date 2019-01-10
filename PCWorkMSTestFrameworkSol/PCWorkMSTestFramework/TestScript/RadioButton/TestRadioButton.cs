using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using PCWorkMSTestFramework.ComponentHelper;
using PCWorkMSTestFramework.Setting;

namespace PCWorkMSTestFramework.TestScript.RadioButton
{
    [TestClass]
    public class TestRadioButton
    {
        [TestMethod, TestCategory("SELECT A RADIO BUTTON")]
        public void ChooseOneRadioButton()
        {
            NavigationHelper.NavigateToURl(ObjectRepository.Config.GetWebsite());

            IWebElement radioElement = ObjectRepository.Driver.FindElement(By.Name("newsletter"));

            radioElement.Click();
        }
    }
}
