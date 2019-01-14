using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using RepPCWorkMSTestFramework.ComponentHelper;
using RepPCWorkMSTestFramework.Settings;

namespace RepPCWorkMSTestFramework.TestScripts.RadioButton
{
    [TestClass]

    public class TestRadioButton
    {
        [TestMethod, TestCategory("SELECT A RADIO BUTTON")]

        public void ChooseOneRadioButton()
        {
            NavigationHelper.NavigateTOURL(ObjectRepository.Config.GetWebsite());

            //var radioButton = ObjectRepository.Driver.FindElement(By.Name("newsletter"));
            //IList<IWebElement> radio = ObjectRepository.Driver.FindElements(By.TagName("input"))

            //foreach (var radioOption in radio)
            //{
            //    if (radioOption.GetAttribute("value").Equals("0"))
            //    {
            //        radioOption.Click();
            //    }

            //}

            //radioButton.Click();

            //RadioButtonHelper.IsRadioButtonSelected(By.Id("newsletter_No"));
            //RadioButtonHelper.ClickOnOneRadioButton(By.Id("newsletter_No"));

            //RadioButtonHelper.GetExactRadioButton(By.TagName("input"));

            Console.WriteLine(RadioButtonHelper.IsRadioButtonSelected(By.XPath("//*[@id=\"content\"]/form/fieldset[3]/div/div/label[2]/input")));
            RadioButtonHelper.ClickOnOneRadioButton(By.XPath("//*[@id=\"content\"]/form/fieldset[3]/div/div/label[2]/input"));
        }
    }
}
