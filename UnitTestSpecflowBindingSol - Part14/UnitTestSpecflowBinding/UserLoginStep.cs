using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace UnitTestSpecflowBinding
{
    [Binding]
    public sealed class UserLoginStep
    {
        [Given(@"I have opened the application")]
        public void GivenIHaveOpenedTheApplication()
        {
            Console.WriteLine();
        }

        [Given(@"I login to application as admin")]
        public void GivenILoginToApplicationAsAdmin()
        {
            Console.WriteLine("Logged in as admin");
       
        }

        [Then(@"I see last date logged in data is (.* days from current date)")]
        public void ThenISeeLastDateLoggedInDataIsDaysFromCurrentDate(DateTime correctDateTime) //DateTime correctDateTime
        {
            Console.WriteLine(correctDateTime);
            //var correctdate = DateTime.Today.AddDays(p0);
            //Console.WriteLine(correctdate);
        }

    }
}
