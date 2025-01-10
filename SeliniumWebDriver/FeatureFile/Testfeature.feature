Feature: Login and create bug in Budzilla

A short summary of the feature
Background: Pre-Condition
Given User at the login page
And File a bug should visiable
@tag1
Scenario: Test the login page of Bugzilla
	When I click on file a bug link
	Then User should be at login page
	When I provide username and password and click on login button
	Then User should be at Enter bug page
	When I provide severity, hardware, platform and summary
	And Click on submit button
	Then Bug should be cretaed
	When User clicked on lodout button 
	Then User should be logged out and should be at home page