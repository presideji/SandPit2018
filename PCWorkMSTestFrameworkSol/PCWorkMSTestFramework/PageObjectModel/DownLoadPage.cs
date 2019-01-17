using OpenQA.Selenium;
using PCWorkMSTestFramework.ComponentHelper;

namespace PCWorkMSTestFramework.PageObjectModel
{
    public class DownLoadPage
    {
        private readonly By _downloadsLink = By.LinkText("Downloads");

        public void DownloadsPageView()
        {
            LinkHelper.ClickLink(_downloadsLink);
        }

    }
}