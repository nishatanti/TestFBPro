Feature: Login
	
Background:
Given User should be on homepage

Scenario: Test btob login functionality
	When Click on Travelagent tab
	And   Enter Username and Password
	| UserName | Password  |
	| FBTEST   | FBTEST123 |

	And   Click on btob SignIn button
	Then  User is sucessfully login for btob 