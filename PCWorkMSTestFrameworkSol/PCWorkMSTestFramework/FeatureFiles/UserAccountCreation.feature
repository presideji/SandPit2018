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
	And I have also input my "<lastname>"
	And I then enter my "<email>"
	And I finally enter my "<phone>"
	And I agree with the policy
	When I selected the continue button
	Then my account should not be created
	And I should not be logged into my homepage

	Examples:
	| firstname | lastname | email         | phone        | 
	| Andre     | dada     | test04@you.com | 07963258457 |
	| Tolu      | Fola     | de04@dc.com    | 01234568977 | 

