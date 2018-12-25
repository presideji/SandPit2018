using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowIntroYouTube.Step_definitions
{
    [Binding]
    public sealed class ExtendedSteps
    {
        public readonly EmployeeDetails employee; // 34a create object for employee details

        public ExtendedSteps(EmployeeDetails emp) //34b create constructor for employee details
        {
            this.employee = emp; //35c assign value to variable just declare in the constructor
            // the above is the context injection feature. Go and copy Steps deiniftions
            //in "SpecFlowFeature1.feature"
        }

        //37. below is the step definition
        [Then(@"I Should get the same value from Extended steps")]
        public void ThenIShouldGetTheSameValueFromExtendedSteps()
        {
            //40. from 39 in SampleFeaturesSteps.cs
            Console.WriteLine(employee.Age);
            Console.WriteLine(employee.Email);
            Console.WriteLine(employee.Name);
            Console.WriteLine(employee.Phone);
        }
        //37b now go to SampleFeaturesSteps.cs



    }
}
