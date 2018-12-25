using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSTestSpecYouTube.Step_definitions;
using SpecFlow.Assist.Dynamic;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace MSTestSpecYouTube
{
    [Binding]
    class SampleFeaturesSteps
    {
        public readonly EmployeeDetails employee;

        public SampleFeaturesSteps(EmployeeDetails emp)
        {
            this.employee = emp;
        }


        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int numbers)
        {
            Console.WriteLine(numbers);
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            Console.WriteLine("Pressed Add button");
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int result)
        {
            if (result == 120)
                Console.WriteLine("The test PASSED");
            else

            {
                Console.WriteLine("This test FAILED");
                //throw new Exception("The value is different");
            }

        }

        [When(@"I fill all the mandatory details in form")]
        public void WhenIFillAllTheMandatoryDetailsInForm(Table table)
        {
            {
                var data = table.CreateDynamicSet();
                foreach (var item in data)
                {
                    employee.Age = (int)item.Age;
                    employee.Email = (string)item.Email;
                    employee.Name = (string)item.Name;
                    employee.Phone = (long)item.Phone;

                }

            }

            //EmployeeDetails details =  table.CreateInstance<EmployeeDetails>();
            //Console.WriteLine(details.Age);
            //Console.WriteLine(details.Email);
            //Console.WriteLine(details.Name);
            //Console.WriteLine(details.Phone);


            /*
            var details = table.CreateSet<EmployeeDetails>();

            foreach (EmployeeDetails emp in details)
            {
                Console.WriteLine("The Details of Employee :" + emp.Name);
                Console.WriteLine("***************************************");
                Console.WriteLine(emp.Age);
                Console.WriteLine(emp.Email);
                Console.WriteLine(emp.Name);
                Console.WriteLine(emp.Phone);

            }
                    */
                
            //Work with Dynamics Assist
            var details = table.CreateDynamicSet();

            //Iterate
            foreach (var emp in details)
            {
                Console.WriteLine("The Details of Employee :" + emp.Name);
                Console.WriteLine("***************************************");
                Console.WriteLine(emp.Age);
                Console.WriteLine(emp.Email);
                Console.WriteLine(emp.Name);
                Console.WriteLine(emp.Phone);
            }

        }

        [When(@"I fill all the mandatory details in form (.*), (.*) and (.*)")]
        public void WhenIFillAllTheMandatoryDetailsInFormAnd(string name, int age, Int64 Phone)
        {
            Console.WriteLine("Name :" + name);
            Console.WriteLine("Age :" + age);
            Console.WriteLine("Phone number:" + Phone);

            ScenarioContext.Current["InfoforNextStep"] = "Step1 Passed";

            Console.WriteLine(ScenarioContext.Current["InfoforNextStep"].ToString());

            List<EmployeeDetails> empDetails = new List<EmployeeDetails>()
            {
                new EmployeeDetails()
                {
                    Name = "Abraham",
                    Age = 20,
                    Email = "Abraham@execute.com",
                    Phone = 1231231

                },
                new EmployeeDetails()
                {
                    Name = "Mike",
                    Age = 20,
                    Email = "mike@execute.com",
                    Phone = 345342

                },
                new EmployeeDetails()
                {
                    Name = "Jacob",
                    Age = 33,
                    Email = "jacob@execute.com",
                    Phone = 5458275

                }
            };

            //save the value in scenerio context
            ScenarioContext.Current.Add("EmpDetails", empDetails);

            //Get the value out of scenerio context
           var emplist =  ScenarioContext.Current.Get<IEnumerable<EmployeeDetails>>("EmpDetails");

            foreach (EmployeeDetails emp in emplist)
            {
                Console.WriteLine("The Employee name is " + emp.Name);
                Console.WriteLine("The Employee Age is " + emp.Age);
                Console.WriteLine("The Employee Email is " + emp.Email);
                Console.WriteLine("The Employee Phone is " + emp.Phone);
                Console.WriteLine("\n");
            }

            Console.WriteLine(ScenarioContext.Current.Count);
            Console.WriteLine(ScenarioContext.Current.CurrentScenarioBlock);
        }




    }



}

