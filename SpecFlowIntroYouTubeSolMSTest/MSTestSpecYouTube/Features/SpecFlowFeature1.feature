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
	#Given I have opened my application
	#Then I should see employer details page 
	When I fill all the mandatory details in form
	| Name    | Age | Phone      | Email           |
	| karthik | 28  | 9098023842 | james@gmail.com |
	| John | 28  | 2134234 | terry@test.com |
	| Sam | 28  | 2342348902 | bond@auto.com |
	#And I click the same button
	#Then I should see all the details saved in my application and DB


Scenario Outline: Create a new employee with mandatary details for different iteration
	#Given I have opened my application
	#Then I should see employer details page 
	When I fill all the mandatory details in form <Name>, <Age> and <Phone>
	#And I click the same button
	#Then I should see all the details saved in my application and DB
Examples:
	| Name    | Age | Phone      |
	| karthik | 28  | 9098023842 |
	| John	  | 28  | 2134234    | 
	| Sam     | 28  | 2342348902 |

Scenario: Check if I could get the details entered via Table from Extended Steps
	When I fill all the mandatory details in form
		| Name    | Age | Phone      | Email           |
		| karthik | 28  | 9098023842 | james@gmail.com |
		Then I should get the same value from Extended steps