using System;
using System.Collections.Generic;
using NUnit.Framework;
using TechTalk.SpecFlow;
using SpecFlow.Assist.Dynamic;//27. this will created the dynamic tables
using TechTalk.SpecFlow.Assist;

//14. now let us add this

namespace SpecFlowIntroYouTube.Step_definitions
{
    [Binding]
    class SampleFeaturesSteps
    {
        //38. Create a POCO Object
        public readonly EmployeeDetails employee;

        public SampleFeaturesSteps(EmployeeDetails emp)
        {
            this.employee = emp;
        }


        [Given(@"I have entered (.*) into the calculator")]
        public void
            GivenIHaveEnteredIntoTheCalculator(int numbersclass1) //2.insted of"int p0" let us use some meaningful things
        {
            //ScenarioContext.Current.Pending(); //1. we will delete this line bcos it is not yet implemented
            //3. we now write
            Console.WriteLine(numbersclass1);

        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            // ScenarioContext.Current.Pending(); //4. we will delete this line and type the below
            Console.WriteLine("Press Add Button");

        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int resultclass1) //6.insted of"int p0" let us use some meaningful things
        {
            // ScenarioContext.Current.Pending(); //5. we will delete this line and type the below
            //now we will hard code
            if (resultclass1 == 120)
       //7.grab the real object which has a value 120 in the UI of your real application and replace that

                Console.WriteLine("The Test PASSED");

            else
                Console.WriteLine("The Test FAILED");
            //8.if you change"result == 121" the test willfail but will not show in the result
            //to correct this you need to throw in an exception
            //throw new Exception("The value is different");
        }

        [When(@"I fill all the mandatory details in form")]
        public void WhenIFillAllTheMandatoryDetailsInForm(Table table)
        {
            //39. Create a dynamic set for the table. After this go to extendedsteps
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

            //ScenarioContext.Current.Pending(); //11. let us remove this
            //12. Now let us parse the data for our feature.let us create a custom class"EmployeeDetails"

            //15. now let us create the instance
            //EmployeeDetails details = table.CreateInstance<EmployeeDetails>();

            //17 from the feature file we need to change "createinstance" as it ccan take
            //many data to "create set". we comment it above and rewrite it below

            //  EmployeeDetails details = table.CreateSet<EmployeeDetails>(); // 18. now let us change it to var type


           /* var details = table.CreateSet<EmployeeDetails>();*/ // 28.we will comment this out to differentiate between
           //normal creat table and the assist dynamics one
           //19. now we need to loop all the valuses below out
            // we add for eadh loop

           // foreach (EmployeeDetails emp in details) //29. we will comment this out to differentiate between
                // normal creat table and the assist dynamics one

            //20.we will now move 16 into the cullybrace below

            //30. we will comment the below out to differentiate between
            //normal create table and the assist dynamics one

            //{
            //    //21. we will now add the headings
            //    Console.WriteLine("The Details of Employee :" + emp.Name);
            //    Console.WriteLine("*************************************");
            //    Console.WriteLine(emp.Age);
            //    Console.WriteLine(emp.Email);
            //    Console.WriteLine(emp.Name);
            //    Console.WriteLine(emp.Phone);
            //}


            /*
            //16. now let us print the value
            Console.WriteLine(details.Age);
            Console.WriteLine(details. Email);
            Console.WriteLine(details.Name);
            Console.WriteLine(details.Phone);
             */

        //31 Work with Dynamic Assist
            //table.CreateDynamicInstance()//32 since we are creating a set for each loop we we use "createdynamic set"
         var details = table.CreateDynamicSet(); // it will create a type "dynamic" with all the properties of the table
        
        //Now let us Iterate this value
            foreach (var emp in details)
            {
                Console.WriteLine("The Details of Employee :" + emp.Name);
                Console.WriteLine("*************************************");
                Console.WriteLine(emp.Age);
                Console.WriteLine(emp.Email);
                Console.WriteLine(emp.Name);
                Console.WriteLine(emp.Phone);
            }

            //33. now go to "SpecFlowFeature1.feature-part12"



        }



        //steps generated from 21 in "feature"
        [When(@"I fill all the mandatory details in form (.*), (.*) and (.*)")]
        public void WhenIFillAllTheMandatoryDetailsInFormKarthikAnd(string name, int age,  Int64 Phone)
        {
            //ScenarioContext.Current.Pending(); 23. let us delete this
            Console.WriteLine("Name :" + name);
            Console.WriteLine("Age :" + age);
            Console.WriteLine("Phone number :" + Phone);

            //24. we will now make use of - ScenarioContext.Current - for our Scenerio Context
            ScenarioContext.Current["InfoforNextStep"] = "Step1 Passed";

            Console.WriteLine(ScenarioContext.Current["InfoforNextStep"].ToString());

            //25. now lets us create a list of employee details

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
            //26. Save the value in ScenarioContext
            ScenarioContext.Current.Add("EmpDetails", empDetails);

            //27. get the value out from Scenario Context and store it in a "variable"
            var emplist = ScenarioContext.Current.Get<IEnumerable<EmployeeDetails>>("EmpDetails");

            foreach (EmployeeDetails emp in emplist)
            {
                Console.WriteLine("The Employee name is" + emp.Name);
                Console.WriteLine("The Employee Age is" + emp.Age);
                Console.WriteLine("The Employee Email is" + emp.Email);
                Console.WriteLine("The Employee Phone is" + emp.Phone);
                Console.WriteLine("\n"); // this is just to give blank space
            }

            Console.WriteLine(ScenarioContext.Current.ScenarioInfo.Title);
            Console.WriteLine(ScenarioContext.Current.CurrentScenarioBlock);
            //28. we will now go and create the class "Stepdefinition"
        }


    }





}
