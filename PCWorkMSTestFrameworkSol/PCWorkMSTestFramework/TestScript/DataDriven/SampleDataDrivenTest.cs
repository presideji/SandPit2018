using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PCWorkMSTestFramework.ComponentHelper;
using PCWorkMSTestFramework.PageObjectModel;
using PCWorkMSTestFramework.Setting;

namespace PCWorkMSTestFramework.TestScript.DataDriven
{
    [TestClass]
    public class SampleDataDrivenTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void LoginApp()
        {
            NavigationHelper.NavigateToURl(ObjectRepository.Config.GetWebsite());

            //using Page Object Model below, we have
            var homepage = new HomePage();
            //homepage.SelectRegisterAccountButton().
            //    RegisterNewAccount().
            //    NavigateToDownloadsPage().
            //    ClickDownloadsLink();
            //we can rewrite the above like this;
            homepage.SelectRegisterAccountButton().
                RegisterNewAccount().
                NavigateToDownloadsPage().ClickDownloadsLink();

            Console.WriteLine("this test name is: {0}", TestContext.TestName);
        }

        [TestCleanup]
        public void CloseConsole()
        {
            Console.WriteLine("This test name is: {0}", TestContext.CurrentTestOutcome);
        }
    }
}
