using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MSTestSpecYouTube
{
    [Binding]
    public sealed class TestFixture
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public static void CalledFirstInMyFeature()
        {
            Console.WriteLine("Calling before Features");
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            Console.WriteLine("Calling before Scenerio");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("Calling after scenerio");
        }
    }
}
