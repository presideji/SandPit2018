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

            private readonly By _myAccountTab = By.XPath("//*[@id=\"top-links\"]/ul/li[2]/a/span[1]");
            private readonly By _registerButton = By.XPath("//*[@id=\"top-links\"]/ul/li[2]/ul/li[1]/a");
            private readonly By _logoutButton = By.XPath("//*[@id=\"top-links\"]/ul/li[2]/ul/li[5]/a");

        ////private readonly By _myAccountTab = By.XPath("//*[@id=\"top-links\"]/ul/li[2]/a/span[1]");
        //private readonly By _myAccountTab = By.XPath("//*[@id=\"top - links\"]/ul/li[2]/a");
        //private readonly By _registerButton = By.XPath("//*[@id=\"top-links\"]/ul/li[2]/ul/li[1]/a");
        //private readonly By _logoutButton = By.XPath("//*[@id=\"top-links\"]/ul/li[2]/ul/li[5]/a");

        [TestMethod, TestCategory("CSV READER")]
        //[DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", 
        //@"C:\Users\admin\Documents\CERTIFICATIONS\Software Testing\Auto - Andre\SandPit2018\PCWorkMSTestFrameworkSol\DataFile\UserDataFile.csv", 
        //"UserDataFile#csv", 
        //DataAccessMethod.Sequential)] //YOU CAN ALSO USE - DataAccessMethod.Random)] 

        //// AT WORK 1
        //[DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        //    @"C:\C\UserDataFile.csv #",
        //    "UserDataFile#csv",
        //    DataAccessMethod.Sequential)]

        // AT WORK 2
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                @"\\gandalf\home$\dakinola\SandPit2018\PCWorkMSTestFrameworkSol\PCWorkMSTestFramework\DataFiles\UserDataFile.csv",
                "UserDataFile#csv",
                DataAccessMethod.Sequential)]

        
        public void RegisterNewAccountDdt()
            {
            NavigationHelper.NavigateToURl(ObjectRepository.Config.GetWebsite());
            //var homepage = new HomePage();
            //    homepage.SelectRegisterAccountButton(); // let us write this in a different way
            MenuButtonHelper.SelectMenuButton(_myAccountTab);
            MenuButtonHelper.SelectMenuButton(_registerButton);

            TextboxHelper.SendTextToTextbox(_firstname, TestContext.DataRow["FIRSTNAME"].ToString());
            TextboxHelper.SendTextToTextbox(_lastname, TestContext.DataRow["LASTNAME"].ToString());
            TextboxHelper.SendTextToTextbox(_email, TestContext.DataRow["EMAIL"].ToString());
            TextboxHelper.SendTextToTextbox(_phone, TestContext.DataRow["PHONE"].ToString());
            TextboxHelper.SendTextToTextbox(_password, TestContext.DataRow["PASSWORD"].ToString());
            TextboxHelper.SendTextToTextbox(_confirmPassword, TestContext.DataRow["CONFIRMPASSWORD"].ToString());
            RadioButtonHelper.ClickOneRadiobutton(_newsletterYes);
            CheckboxHelper.ClickCheckbox(_policyBox);
            MenuButtonHelper.SelectMenuButton(_continueButton);
            MenuButtonHelper.SelectMenuButton(_myAccountTab);
            MenuButtonHelper.SelectMenuButton(_logoutButton);
                //return new UserAccountPage();
        }


        [TestMethod, TestCategory("EXCEL READER")]

        // AT WORK FOR EXCEL - 3
        [DataSource("System.Data.Odbc",
        @"Dsn=Excel Files;dbq=\\gandalf\home$\dakinola\SandPit2018\PCWorkMSTestFrameworkSol\PCWorkMSTestFramework\DataFiles\UserDataFileExcel.xlsx;",
        "UserData$",
        DataAccessMethod.Sequential)]


        public void ReadFromExcelFile()
        {
            NavigationHelper.NavigateToURl(ObjectRepository.Config.GetWebsite());

            MenuButtonHelper.SelectMenuButton(_myAccountTab);
            MenuButtonHelper.SelectMenuButton(_registerButton);

            TextboxHelper.SendTextToTextbox(_firstname, TestContext.DataRow["FIRSTNAME"].ToString());
            TextboxHelper.SendTextToTextbox(_lastname, TestContext.DataRow["LASTNAME"].ToString());
            TextboxHelper.SendTextToTextbox(_email, TestContext.DataRow["EMAIL"].ToString());
            TextboxHelper.SendTextToTextbox(_phone, TestContext.DataRow["PHONE"].ToString());
            TextboxHelper.SendTextToTextbox(_password, TestContext.DataRow["PASSWORD"].ToString());
            TextboxHelper.SendTextToTextbox(_confirmPassword, TestContext.DataRow["CONFIRMPASSWORD"].ToString());
            RadioButtonHelper.ClickOneRadiobutton(_newsletterYes);
            CheckboxHelper.ClickCheckbox(_policyBox);
            MenuButtonHelper.SelectMenuButton(_continueButton);
            MenuButtonHelper.SelectMenuButton(_myAccountTab);
            MenuButtonHelper.SelectMenuButton(_logoutButton);

        }


        [TestMethod, TestCategory("XML READER")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            @"\\gandalf\home$\dakinola\SandPit2018\PCWorkMSTestFrameworkSol\PCWorkMSTestFramework\DataFiles\UserDataFileXML.xml",
            "Row",
            DataAccessMethod.Sequential)]

        public void ReadFromXMLFile()
        {
            NavigationHelper.NavigateToURl(ObjectRepository.Config.GetWebsite());

            MenuButtonHelper.SelectMenuButton(_myAccountTab);
            MenuButtonHelper.SelectMenuButton(_registerButton);

            TextboxHelper.SendTextToTextbox(_firstname, TestContext.DataRow["FIRSTNAME"].ToString());
            TextboxHelper.SendTextToTextbox(_lastname, TestContext.DataRow["LASTNAME"].ToString());
            TextboxHelper.SendTextToTextbox(_email, TestContext.DataRow["EMAIL"].ToString());
            TextboxHelper.SendTextToTextbox(_phone, TestContext.DataRow["PHONE"].ToString());
            TextboxHelper.SendTextToTextbox(_password, TestContext.DataRow["PASSWORD"].ToString());
            TextboxHelper.SendTextToTextbox(_confirmPassword, TestContext.DataRow["CONFIRMPASSWORD"].ToString());
            RadioButtonHelper.ClickOneRadiobutton(_newsletterYes);
            CheckboxHelper.ClickCheckbox(_policyBox);
            MenuButtonHelper.SelectMenuButton(_continueButton);
            MenuButtonHelper.SelectMenuButton(_myAccountTab);
            MenuButtonHelper.SelectMenuButton(_logoutButton);

        }

            //[TestMethod]
            //public void NavigateToAccountPageOne()
            //{
            //    MenuButtonHelper.SelectMenuButton(_accountPageLink);

            //}



    }
}