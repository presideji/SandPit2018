using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RepPCWorkMSTestFramework
{


    [TestClass]
    public class RepFirstMSTest
    {
        [ClassInitialize]
        public static void ConnectionToDataBase(TestContext testContext)
        {
            Console.WriteLine("Open connections to database");
        }

        [TestInitialize]
       public void LaunchBrowser()
        {
            Console.WriteLine("Launch the browser!");
        }

        [TestMethod, TestCategory("SMOKE TEST")]
        public void ClickAButton()
        {
            Console.WriteLine("Click on a button");
        }

        [TestMethod]
        [TestCategory("PENETRATION TEST")]
        public void EnterAText()
        {
            Console.WriteLine("Enter a text into the field");
        }

        [TestMethod]
        public void NavigateToPage()
        {
            Console.WriteLine("Navigate to certain page");
        }

        [TestCleanup]
        public void TearDownBrowser()
        {
            Console.WriteLine("Close all open browser");
        }

        [ClassCleanup]
        public static void DisconnectFromDatabase()
        {
            Console.WriteLine("Close all database connection");
        }
    }
}
