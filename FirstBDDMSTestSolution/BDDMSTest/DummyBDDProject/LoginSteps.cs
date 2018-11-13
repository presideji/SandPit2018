using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDDMSTest.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace BDDMSTest.DummyBDDProject
{
    [Binding]
    public sealed class LoginSteps
    {
        private AccountPage _accountPage;
        private string _username;
        private string _password;
        private WelcomePage _welcomePage;
        private IWebDriver _driver;

        //now let us put "hooks" here cos 
        //"IWebDriver driver = new ChromeDriver();" is not
        //where it should be

        [BeforeScenario()]
        public void SetUpTest()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("http://live.guru99.com/index.php");
            _driver.Manage().Window.Maximize();
        }

        [AfterScenario()]
        public void CloseTest()
        {
            _driver.Quit();
        }

        [Given(@"I have username ""(.*)"" & password ""(.*)""")]
        public void GivenIHaveUsernamePassword(string username, string password)
        {
            this._username = username;
            this._password = password;
            //IWebDriver driver = new ChromeDriver();
            BasePage basePage = new BasePage(_driver);//let us create a driver above
            _accountPage = basePage.HomePage.GoToAccountPage();
            //bcos we will use "AccountPage" somewhere
            //we do no want to use it here as a local
            //variable

        }

        [When(@"I logon to the application")]
        public void WhenILogonToTheApplication()
        {
            _welcomePage = _accountPage.LoginWith(_username, _password); //let go and find a way to bring d variable
        }

        [Then(@"I should see ""(.*)"" message")]
        public void ThenIShouldSeeMessage(string message)
        {
            Assert.IsTrue(_welcomePage.ValidatSuccessfulLogon(message));
        }


    }
}
