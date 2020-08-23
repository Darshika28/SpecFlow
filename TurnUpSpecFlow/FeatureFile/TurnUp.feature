Feature: TurnUp
	
	
Scenario: Create An Time And Material Page

#You have a Condition
Given I Login into Turn Up Portal

# You perform Action
When I Click on "Time Material" under Administration Dropdown

# verification Of the Action
Then I Verify that I am On Time-Material Page

Given Click on Create new button
When Create new record in Time Material Page
Then I Verify that record is created
