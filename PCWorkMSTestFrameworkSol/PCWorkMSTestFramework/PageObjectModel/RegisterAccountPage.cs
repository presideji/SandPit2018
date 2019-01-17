using System;
using OpenQA.Selenium;
using PCWorkMSTestFramework.ComponentHelper;

namespace PCWorkMSTestFramework.PageObjectModel
{
    public class RegisterAccountPage
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

            public UserAccountPage RegisterNewAccount()
            {
                TextboxHelper.SendTextToTextbox(_firstname, "Andre");
                TextboxHelper.SendTextToTextbox(_lastname, "Deji");
                TextboxHelper.SendTextToTextbox(_email, "test34@tobe.com");
                TextboxHelper.SendTextToTextbox(_phone, "079390865512");
                TextboxHelper.SendTextToTextbox(_password, "letmein123");
                TextboxHelper.SendTextToTextbox(_confirmPassword, "letmein123");
                RadioButtonHelper.ClickOneRadiobutton(_newsletterYes);
                CheckboxHelper.ClickCheckbox(_policyBox);
                MenuButtonHelper.SelectMenuButton(_continueButton);
                return new UserAccountPage();

        }

            public void NavigateToAccountPage()
            {
                MenuButtonHelper.SelectMenuButton(_accountPageLink);

        }



    }
}