using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using RepPCWorkMSTestFramework.ComponentHelper;
using RepPCWorkMSTestFramework.Settings;

namespace RepPCWorkMSTestFramework.TestScripts.WebElementTest
{
    [TestClass]
    public class ElementsTest
    {
        [TestMethod, TestCategory("WEB ELEMENT TEST")]
        public void GetWebElement()
        {
            NavigationHelper.NavigateTOURL(ObjectRepository.Config.GetWebsite());//this gets us to tyeh website

            try
            {
                //now let us look for elements on the web page
                ObjectRepository.Driver.FindElement(By.Id("hero"));
                ObjectRepository.Driver.FindElement(By.ClassName("navbar-right"));
                ObjectRepository.Driver.FindElement(By.TagName("a"));
                ObjectRepository.Driver.FindElement(By.XPath("//*[@id=\"hero\"]/div[1]/div[1]/div/h1"));
                // ObjectRepository.Driver.FindElement(By.LinkText("Visit Marketplace"));
                // ObjectRepository.Driver.FindElement(By.PartialLinkText("Visit"));
                ObjectRepository.Driver.FindElement(By.CssSelector("#hero > div.container > div.row > div > p.hidden-xs > a.btn.btn-white.btn-xl"));
                ObjectRepository.Driver.FindElement(By.Name("tryme"));
            }
            catch (NoSuchElementException e)
            {

                Console.WriteLine(e);
            }
           // //now let us look for elements on the web page
           // ObjectRepository.Driver.FindElement(By.Id("hero"));
           // ObjectRepository.Driver.FindElement(By.ClassName("navbar-right"));
           // ObjectRepository.Driver.FindElement(By.TagName("a"));
           //ObjectRepository.Driver.FindElement(By.XPath("//*[@id=\"hero\"]/div[1]/div[1]/div/h1"));
           // // ObjectRepository.Driver.FindElement(By.LinkText("Visit Marketplace"));
           // // ObjectRepository.Driver.FindElement(By.PartialLinkText("Visit"));
           // ObjectRepository.Driver.FindElement(By.CssSelector("#hero > div.container > div.row > div > p.hidden-xs > a.btn.btn-white.btn-xl"));
           // //ObjectRepository.Driver.FindElement(By.Name(""));

            //we will cut the above and put it in the "try" braclets


        }

        [TestMethod, TestCategory("LIST TEST")]
        public void GetListTest()
        {
            NavigationHelper.NavigateTOURL(ObjectRepository.Config.GetWebsite());


            IList<string> list = new List<string>();
            list.Add("object one");//0
            list.Add("object two");//1
            list.Add("object three");//2

            Console.WriteLine("list size is: {0}", list.Count);
            list.RemoveAt(1);
            Console.WriteLine("list size is now: {0}", list.Count);
            Console.WriteLine("list index 1 is:{0}", list[0]);
            Console.WriteLine("list index 2 is: {0}", list[1]);
            list.Clear();
            Console.WriteLine("list size is: {0}", list.Count);

            ReadOnlyCollection<IWebElement> listColl = ObjectRepository.Driver.FindElements(By.TagName("div"));
            Console.WriteLine("size of listcoll is: {0}", listColl.Count);
            Console.WriteLine("first element is: {0}", listColl.ElementAt(1));

        }
    }
}
