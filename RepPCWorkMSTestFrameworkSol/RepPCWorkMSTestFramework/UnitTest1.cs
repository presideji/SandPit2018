using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RepPCWorkMSTestFramework
{
    [TestClass]
    public class UnitTest1
    {
        [AssemblyInitialize]
        public static void BeforeAssembly(TestContext textContext)
        {
            Console.WriteLine("This is from the assembly method");
        }

        [TestMethod]
        [TestCategory("SMOKE TEST")]
        public void ClickOnDropDownMenu()
        {
            Console.WriteLine("Click on a dropdown menu");
        }


        [TestMethod]
        public void ClickARadioButton()
        {
            Console.WriteLine("Click on a the radio button");
        }


        [AssemblyCleanup]
        public static void AfterAssembly()
        {
            Console.WriteLine("This is to close assembly method");
        }


    }
}
