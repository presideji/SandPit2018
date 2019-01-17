using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using PCWorkMSTestFramework.ComponentHelper;

namespace PCWorkMSTestFramework.PageObjectModel
{
    public class HomePage
    {
        #region element      
        // this is the start of the webelement region
        private readonly By _myAccountTab = By.XPath("//*[@id=\"top-links\"]/ul/li[2]/a");
        //private readonly By _myAccountTab = By.XPath("//*[@id=\"top-links\"]/ul/li[2]/a/span[1]");
        private readonly By _registrationButton = By.XPath("//*[@id=\"top-links\"]/ul/li[2]/ul/li[1]/a");
        #endregion
        //this is the end of the webelement region
        
         #region actions
        //this is the start of the actions region
        public RegisterAccountPage SelectRegisterAccountButton()
        {
            MenuButtonHelper.SelectMenuButton(_myAccountTab);
            MenuButtonHelper.SelectMenuButton(_registrationButton);
            return new RegisterAccountPage();
        }


        public RegisterAccountPage SelectRegisterAccountButtontwo()
        {
            MenuButtonHelper.SelectMenuButton(_myAccountTab);
            MenuButtonHelper.SelectMenuButton(_registrationButton);
            return new RegisterAccountPage();
        }
        #endregion
    }
}
