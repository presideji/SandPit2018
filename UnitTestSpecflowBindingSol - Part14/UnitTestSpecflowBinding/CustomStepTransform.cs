using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace UnitTestSpecflowBinding
{
    [Binding]
    public class CustomStepTransform
    {
        [StepArgumentTransformation(@"(\d+) days from current date")]
        public DateTime DayAdderTransform(int days)
        {
            return DateTime.Today.AddDays(days);


        }
    }
}
