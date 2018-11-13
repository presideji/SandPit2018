Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@SmokeTest
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen


Scenario: Create a new employee with mandatary details
	#Given I have opened my application //9 we will comment this out bcos we do not have application itself
	#Then I should see employer details page //10 we will comment this out bcos we do not have application itself.//our intentionis to see how to handle nultiple data
	When I fill all the mandatory details in form
	| Name    | Age | Phone      | Email           |
	| karthik | 28  | 9098023842 | james@gmail.com |
	| John	 | 30  | 2134234 | john@gmail.com | 
	| Sam | 28  | 2342348902 | sam@gmail.com |
	#And I click the same button //33.disable so that we can run Dynamic table creation
	#Then I should see all the details saved in my application and DB //33.disable so that we can run Dynamic table creation
	#18.
	##In line 20 and 21 we are putting in more data. Now let us go to "SamplefeatureSteps"
	#And try to print out all the values we have just included
	

	#21. let us create new set of scenerio below
	
Scenario Outline: Create a new employee with mandatary details for different iteration
	#Given I have opened my application
	#Then I should see employer details page
	When I fill all the mandatory details in form <Name>, <Age> and <Phone>
	#And I click the same button
	#Then I should see all the details saved in my application and DB
Examples:
	| Name    | Age | Phone      |
	| karthik | 28  | 9098023842 |
	| John    | 30  | 2134234	 |
	| Sam	  | 28  | 2342348902 |
	
	#22. let us now generate the steps and put it in features
