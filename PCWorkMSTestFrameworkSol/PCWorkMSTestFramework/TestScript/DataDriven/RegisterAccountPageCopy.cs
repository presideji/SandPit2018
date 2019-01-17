using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using PCWorkMSTestFramework.ComponentHelper;
using PCWorkMSTestFramework.PageObjectModel;
using PCWorkMSTestFramework.Setting;

namespace PCWorkMSTestFramework.TestScript.DataDriven
{
    [TestClass]

    
    public class RegisterAccountPageCopy
    {
        public TestContext TestContext { get; set; }
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
            
            [TestMethod, TestCategory("DDT")]
            [DataSource("Microsoft.ACE.OLEDB.14.0", 
            @"C:\Users\admin\Documents\CERTIFICATIONS\Software Testing\Auto - Andre\SandPit2018\PCWorkMSTestFrameworkSol\UserDataFile.CSV", 
            "UserData#csv", 
            DataAccessMethod.Sequential)]
            public void RegisterNewAccountDdt()
            {
            NavigationHelper.NavigateToURl(ObjectRepository.Config.GetWebsite());
            var homepage = new HomePage();
                homepage.SelectRegisterAccountButton();

            TextboxHelper.SendTextToTextbox(_firstname, TestContext.DataRow["FIRSTNAME"].ToString());
            TextboxHelper.SendTextToTextbox(_lastname, TestContext.DataRow["LASTNAME"].ToString());
            TextboxHelper.SendTextToTextbox(_email, TestContext.DataRow["EMAIL"].ToString());
            TextboxHelper.SendTextToTextbox(_phone, TestContext.DataRow["PHONE"].ToString());
            TextboxHelper.SendTextToTextbox(_password, TestContext.DataRow["PASSWORD"].ToString());
            TextboxHelper.SendTextToTextbox(_confirmPassword, TestContext.DataRow["CONFIRMPASSWORD"].ToString());
            RadioButtonHelper.ClickOneRadiobutton(_newsletterYes);
                CheckboxHelper.ClickCheckbox(_policyBox);
                MenuButtonHelper.SelectMenuButton(_continueButton);
                //return new UserAccountPage();

        }
            [TestMethod]
            public void NavigateToAccountPageOne()
            {
                MenuButtonHelper.SelectMenuButton(_accountPageLink);

        }



    }
}