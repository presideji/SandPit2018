using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using RepPCWorkMSTestFramework.ComponentHelper;
using RepPCWorkMSTestFramework.Settings;

namespace RepPCWorkMSTestFramework.TestScripts.TextBoxTest
{
    [TestClass]
    public class TestTextBox
    {
        [TestMethod, TestCategory("CLEAR A TEXTBOX")]
        public void TextBox()
        {
            NavigationHelper.
                NavigateTOURL(ObjectRepository.
                Config.
                GetWebsite());

            LinkHelper.ClickLink(By.LinkText("Login"));

            //IWebElement EmailBoxField = ObjectRepository.
            //    Driver.
            //    FindElement(By.Id("input-email"));
            //EmailBoxField.Clear();
            TextboxHelper.ClearText(By.Id("input-email"));
            TextboxHelper.SendTextToTextbox(By.Id("input-email"), ObjectRepository.Config.GetUsername());
        }
    }
}
