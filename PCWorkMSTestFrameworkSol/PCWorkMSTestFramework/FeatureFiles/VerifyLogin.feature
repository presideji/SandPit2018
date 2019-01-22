Feature: VerifyLogin
	In order to validate the security of the App
	It should only grant access with valid login details
	And refuse access to invalid log in details

	Background: 
		Given I am on the user login page

	@security @smoke
	Scenario: Verify user can only login with valid user details
	And I have entered valid username
	And I have entered a valid password
	When I selected the login button
	Then I should be logged in
	And my homepage should be displayed
	@uat @regression @solo
	Scenario: Verify user can not login with invalid user details
	And I have entered valid username
	And I have entered a invalid password
	When I selected the login button
	Then I should be logged in
	And my homepage should be displayed
