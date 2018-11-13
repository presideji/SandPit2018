using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace BDDMSTest.Pages
{
    public class AccountPage : BasePage
    {
        [FindsBy(How = How.Id, Using = "send2")]

        private IWebElement LoginButton { get; set; }
        [FindsBy(How = How.Id, Using = "pass")]
        private IWebElement Password { get; set; }
        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement Username { get; set; }

        public AccountPage(IWebDriver driver) : base(driver)
        {
        }

        public WelcomePage LoginWith(string username, string password)
        {
            Username.SendKeys(username);
            Password.SendKeys(password);
            LoginButton.Click();
            return new WelcomePage(Driver);
        }

    }
}
