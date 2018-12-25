using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PCWorkMSTestFramework
{
    [TestClass]
    public class FirstMsTest
    {
        //6. Now let us add the below to initilase one time event of connecting to DB
        [ClassInitialize]
        public static void ConnectToDatabase(TestContext testContext) //8.we have included "static" - in "public void ConnectToDatabase().then run
        {
            Console.WriteLine("Open connection to the database");
        }

        //2. after setting all the methods now add this."testinitialize"
        [TestInitialize]
        public void LaunchBrowser()
        {
            Console.WriteLine("Launch the browser!");
        }

        [TestMethod,
         TestCategory("SMOKE TEST")] //18 let us add this to ignore, then change it back again.if you click on 
        //ignore and then click on the hammer sign and "attribute". it will put all of them on one line
         //15.now let us categorise the test
        public void ClickAButton() //5. now let us change all the "ShowFirstTest" and the rest to proper code
        {
            Console.WriteLine("Click on a button"); //3. now let us change all test  in "cw"
        }

        [TestMethod]
        [TestCategory("PENETRATION TEST")] //16.now let us categorise the test and rebuild. go to "unittest1"
        public void EnterAText()
        {
            Console.WriteLine("Enter text into text field");
        }

        [TestMethod]
        public void NavigateToPage()
        {
            Console.WriteLine("Navigate to a certain page");
        }

        //4. Now add clean up
        [TestCleanup]
        public void TearDownBrowser()
        {
            Console.WriteLine("Close all open browsers");
        }

        //7. now let us clean up the database by disconnecting from it. we then run it
        [ClassCleanup]
        public static void DisconnectFromDatabase() //9. let us put "static" in " public void DisconnectFromDatabase()" n run
            //10.move to the "UnitTest1.cs"
        {
            Console.WriteLine("Close connection to the database");
        }
    }
}
