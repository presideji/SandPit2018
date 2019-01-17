using OpenQA.Selenium;
using PCWorkMSTestFramework.ComponentHelper;

namespace PCWorkMSTestFramework.PageObjectModel
{
    public class UserAccountPage
    {
        private readonly By _accountsLink = By.LinkText("Account");
        
        public UserDetailsPage NavigateToDownloadsPage()
        {
            LinkHelper.ClickLink(_accountsLink);
            return new UserDetailsPage();

        }
    }
}