Feature: Customer_Login
	simple feature to demonstrate customer login feature

@user
Scenario: Login for customer portal
	Given I have opened the application
	And I login to application
	Then I see customer portal
