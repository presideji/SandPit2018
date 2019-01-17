using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PCWorkMSTestFramework.ComponentHelper;
using PCWorkMSTestFramework.PageObjectModel;
using PCWorkMSTestFramework.Setting;

namespace PCWorkMSTestFramework.POM
{
    [TestClass]
    public class TestPOM
    {
        [TestMethod]
        public void RunFirstPOMTest()
        {
            NavigationHelper.NavigateToURl(ObjectRepository.Config.GetWebsite());

            //HomePage homePage = new HomePage();
            //RegisterAccountPage registerAccountPage = homePage.SelectRegisterAccountButton();
            //UserAccountPage userAccountPage = registerAccountPage.RegisterNewAccount();
            //DownloadPage downloadPage = userAccountPage.NavigateToDownloadsPage();
            //downloadPage.DownloadsPageView();

            var homePage = new HomePage();
            homePage.SelectRegisterAccountButton().RegisterNewAccount().NavigateToDownloadsPage().ClickDownloadsLink();


        }
    }
}
