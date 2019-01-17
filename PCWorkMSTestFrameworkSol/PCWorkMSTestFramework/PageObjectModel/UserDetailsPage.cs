using OpenQA.Selenium;
using PCWorkMSTestFramework.ComponentHelper;

namespace PCWorkMSTestFramework.PageObjectModel
{
    public class UserDetailsPage
    {
        private readonly By _downloadsLink = By.XPath("//*[@id=\"content\"]/ul[2]/li[2]/a");

        public void ClickDownloadsLink()
        {
            LinkHelper.ClickLink(_downloadsLink);
           // return new UserDetailsPage();

        }
    }
}