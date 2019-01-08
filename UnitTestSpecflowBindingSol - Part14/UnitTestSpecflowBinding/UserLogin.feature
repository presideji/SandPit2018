Feature: User_Login
	simple feature to demonstrate user login feature

@user
Scenario: Login for user portal
	Given I have opened the application
	And I login to application as admin
	Then I see last date logged in data is 5 days from current date
