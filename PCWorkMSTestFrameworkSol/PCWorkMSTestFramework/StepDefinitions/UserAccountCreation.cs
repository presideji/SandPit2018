using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using PCWorkMSTestFramework.ComponentHelper;
using PCWorkMSTestFramework.Setting;
using TechTalk.SpecFlow;

namespace PCWorkMSTestFramework.StepDefinitions
{
    [Binding]
    public sealed class UserAccountCreation
    {
        private readonly By _firstname = By.Id("input-firstname");
        private readonly By _lastname = By.Id("input-lastname");
        private readonly By _email = By.Id("input-email");
        private readonly By _phone = By.Id("input-telephone");
        private readonly By _password = By.Id("input-password");
        private readonly By _confirmPassword = By.Id("input-confirm");
        private readonly By _newsletterYes = By.XPath("//*[@id=\"content\"]/form/fieldset[3]/div/div/label[1]/input");
        private readonly By _policyBox = By.XPath("//*[@id=\"content\"]/form/div/div/input[1]");
        private readonly By _continueButton = By.ClassName("btn-primary");
        private readonly By _accountPageLink = By.LinkText("Account");

        private readonly By _myAccountTab = By.XPath("//*[@id=\"top-links\"]/ul/li[2]/a/span[1]");
        private readonly By _registerButton = By.XPath("//*[@id=\"top-links\"]/ul/li[2]/ul/li[1]/a");
        private readonly By _logoutButton = By.XPath("//*[@id=\"top-links\"]/ul/li[2]/ul/li[5]/a");


        [Given(@"I am on account creation page")]
        public void GivenIAmOnAccountCreationPage()
        {
            NavigationHelper.
                NavigateToURl(ObjectRepository.
                Config.
                GetWebsite());
            MenuButtonHelper.SelectMenuButton(_myAccountTab);
            MenuButtonHelper.SelectMenuButton(_registerButton);
         }


        [Given(@"I have entered my firstname")]
        public void GivenIHaveEnteredMyFirstname()
        {
            TextboxHelper.SendTextToTextbox(_firstname, "AndreaBeans");
        }

        [Given(@"I have entered my lastname")]
        public void GivenIHaveEnteredMyLastname()
        {
           TextboxHelper.SendTextToTextbox(_lastname, "Ade");
        }

        [Given(@"I have entered my email address")]
        public void GivenIHaveEnteredMyEmailAddress()
        {
            TextboxHelper.SendTextToTextbox(_email, "wehdey1@yo.com");
        }

        [Given(@"I have entered my telephone number")]
        public void GivenIHaveEnteredMyTelephoneNumber()
        {
            TextboxHelper.SendTextToTextbox(_phone, "0123584675");
        }

        [When(@"I selected the continue button")]
        public void WhenISelectedTheContinueButton()
        {
            MenuButtonHelper.SelectMenuButton(_continueButton);
        }

        [Then(@"my account should be created")]
        public void ThenMyAccountShouldBeCreated()
        {
            
        }

        [Then(@"I should be logged into my homepage")]
        public void ThenIShouldBeLoggedIntoMyHomepage()
        {
         
        }

        //[Given(@"I have entered my ""(.*)""")]
        //public void GivenIHaveEnteredMy(string firstname)
        //{
        //    TextboxHelper.SendTextToTextbox(_firstname, firstname );
        //}

        //[Given(@"I have also entered my ""(.*)""")]
        //public void GivenIHaveAlsoEnteredMy(string lastname)
        //{
        //    TextboxHelper.SendTextToTextbox(_lastname, lastname);
        //}

        //[Given(@"I then enter my ""(.*)""")]
        //public void GivenIThenEnterMy(string email)
        //{
        //  TextboxHelper.SendTextToTextbox(_email, email);
        //}

        //[Given(@"I finally enter my ""(.*)""")]
        //public void GivenIFinallyEnterMy(string phone)
        //{
        //    TextboxHelper.SendTextToTextbox(_phone, phone);
        //}

        ////[Given(@"I entered my ""(.*)""")]
        ////public void GivenIEnteredMy(string password)
        ////{
        ////    TextboxHelper.SendTextToTextbox(_password, password);

        ////}

        ////[Given(@"I confirmed my ""(.*)""")]
        ////public void GivenIConfirmedMy(string confirmpassword)
        ////{
        ////    TextboxHelper.SendTextToTextbox(_confirmPassword, confirmpassword);
        ////}


        ////[Given(@"I agree with the policy")]
        ////public void GivenIAgreeWithThePolicy()
        ////{
        ////    MenuButtonHelper.SelectMenuButton(_policyBox);
        ////}



    }
}
