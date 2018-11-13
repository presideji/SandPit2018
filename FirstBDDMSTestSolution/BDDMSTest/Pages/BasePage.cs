using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace BDDMSTest.Pages
{
    public class BasePage
    {
        private HomePage _homePage;
        protected IWebDriver Driver { get; }

        //1. now let us add a connstructor
        public BasePage(IWebDriver driver)
        {
            this.Driver = driver;
            PageFactory.InitElements(Driver, this);
        }

        public HomePage HomePage
        {
            get
            {
                if (_homePage == null) _homePage = new HomePage(Driver);
                return _homePage;
            }
        }
        
    }
}
