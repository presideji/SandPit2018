using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PCWorkMSTestFramework
{
    [TestClass]
    public class UnitTest1
    {
        [AssemblyInitialize]
        public static void BeforeAssembly(TestContext testContext) //11. we will change "public void AfterAssembly()" to "public static void AfterAssembly()" cos is running once
        {
            Console.WriteLine("This is to start the Assembly method");
        }

        //14. let us see how test category works. //17. we will put it here- the category
        [TestMethod]
        [TestCategory("SMOKE TEST")]
        public void ClickOnDropDownMenu()
        {
            Console.WriteLine("Click on a dropdown menu");
        }

        [TestMethod]
        public void ClickARadioButton()
        {
            Console.WriteLine("Click on a radio button"); 
        }

        [AssemblyCleanup]
        public static void AfterAssembly() //12. we will change "public void AfterAssembly()" to "public static void AfterAssembly()" cos is running once
        {
            Console.WriteLine("This is to close the Assembly method");
        }


    }
}
