@SMOKETESTbdd
Feature: UserAccountCreation
	User should be able to create an account
	When all mandatory fields are completed

	Background: 
	Given I am on account creation page

	Scenario: Create an account with mandantory field completed
	And I have entered my firstname
	And I have entered my lastname
	And I have entered my email address
	And I have entered my telephone number
	When I selected the continue button
	Then my account should be created
	And I should be logged into my homepage

	Scenario Outline: Don't create an account if any mandatory field is missed
	And I have entered my "<firstname>"
	And I have entered my "<lastname>"
	And I have entered my "<emailaddress>"
	And I have entered my "<phonenumber>"
	When I selected the continue button
	Then my account should not be created
	And I should not be logged into my homepage

	Examples:
	| firstname | lastname | emailaddress | phonenumber |
	|  Andre    | dada     | test1@you.com| 07963258457 |
	| Tolu	    |  Fola    | de1@dc.com   | 01234568977 |
	
