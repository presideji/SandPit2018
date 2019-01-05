using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using PCWorkMSTestFramework.ComponentHelper;
using PCWorkMSTestFramework.Setting;

namespace PCWorkMSTestFramework.TestScript.TextBoxTest
{
    [TestClass]
    public class TestTextBox
    {
        [TestMethod, TestCategory("CLEAR A TEXTBOX ")]
        public void TextBox()
        {
          NavigationHelper.
                NavigateToURl(ObjectRepository.
                Config.
                GetWebsite());

            LinkHelper.ClickLink(By.LinkText("Login"));  
            //the above click on login tab
            //IWebElement emailBoxField = ObjectRepository.
            //    Driver.
            //    FindElement(By.Id("input-email"));
            //emailBoxField.Clear();
            TextboxHelper.ClearTextBox(By.Id("input-email"));
            TextboxHelper.SendTextToTextbox(By.Id("input-email"),
                ObjectRepository.Config.GetUsername());


        }
    }
}
