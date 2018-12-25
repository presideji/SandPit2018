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
        [Given(@"I login to application")]
        //[Scope(Feature = "Customer_Login")]
        [Scope(Scenario = "Customer_Login")]
        public void GivenILoginToApplication()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
