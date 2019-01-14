using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using RepPCWorkMSTestFramework.ComponentHelper;
using RepPCWorkMSTestFramework.Settings;

namespace RepPCWorkMSTestFramework.TestScripts.Checkbox
{
    [TestClass]
    public class TestCheckbox
    {
        [TestMethod, TestCategory("SELECT A CHECKBOX")]

        public void TestTextbox()
        {
            NavigationHelper.NavigateTOURL(ObjectRepository.Config.GetWebsite());

            IWebElement checkElement = ObjectRepository.Driver.FindElement(By.Name("agree"));
            checkElement.Click();

            CheckboxHelper.IsCheckboxSelected(By.Name("agree"));
            CheckboxHelper.ClickCheckbox(By.Name("agree"));

        }
    }
}
