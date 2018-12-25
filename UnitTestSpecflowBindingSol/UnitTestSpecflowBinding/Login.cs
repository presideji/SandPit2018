using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace UnitTestSpecflowBinding
{
    [Binding]
    public sealed class Login
    {
        [Given(@"I have opened the application")]
        public void GivenIHaveOpenedTheApplication()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I login to application")]
        //[Scope(Feature = "User_Login")]
        [Scope(Tag = "user")]
        public void GivenILoginToApplication()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I see customer portal")]
        public void ThenISeeCustomerPortal()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I see user portal")]
        public void ThenISeeUserPortal()
        {
            ScenarioContext.Current.Pending();
        }


    }
}
