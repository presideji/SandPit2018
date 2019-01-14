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

            Console.WriteLine(RadioButtonHelper.IsRadioButtonSelected(By.XPath("//*[@id=\"content\"]/form/fieldset[3]/div/div/label[2]/input")));
            RadioButtonHelper.ClickOneRadiobutton(By.XPath("//*[@id=\"content\"]/form/fieldset[3]/div/div/label[2]/input"));

            ////var radioButton = ObjectRepository.Driver.FindElement(By.Name("newsletter"));
            //IList<IWebElement> radio = ObjectRepository.Driver.FindElements(By.TagName("input"));

            //foreach (var radioOption in radio)
            //{
            //    if (radioOption.GetAttribute("value").Equals("0"))
            //    {
            //        radioOption.Click();
            //    }
            //}
            //radioButton.Click();

            //RadioButtonHelper.IsRadioButtonSelected(By.Id("newsletter_No"));//this is a place holder. A "hack"
            //RadioButtonHelper.ClickOneRadiobutton(By.Id("newsletter_No"));

            //RadioButtonHelper.IsRadioButtonSelected(By.Id("newsletter"));
            //RadioButtonHelper.ClickOneRadiobutton(By.Id("newsletter"));

            //RadioButtonHelper.GetExactradioButton(By.TagName("input"));


        }
    }
}
