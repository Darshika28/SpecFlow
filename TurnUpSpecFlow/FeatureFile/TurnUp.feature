Feature: TurnUp
	
	
Scenario: Create An Time And Material Page

#You have a Condition
Given I Login into Turn Up Portal

# You perform Action
When I Click on "Employee" under Administration Dropdown

# verification Of the Action
Then I Verify that I am On Employee Page
