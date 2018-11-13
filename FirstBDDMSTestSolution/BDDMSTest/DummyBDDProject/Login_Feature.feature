Feature: Login Feature
	As a customer
	I want to Logon
	So I can track my purchase

#@Log On
#Scenario: test login functionality 1
#	Given I have username and password
#	When I logon to the application
#	Then i should see Welcome message


#Scenario: test login functionality 2
#	Given I have username and password
#	And I have password
#	When I logon to the application
#	And Wait for the login to happen
#	Then I should see Welcome message
#	And I signout


Scenario: test login functionality 3
	Given I have username "danala@test.com" & password "password123"
	When I logon to the application
	Then I should see "Dan Alaska" message