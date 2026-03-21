Feature: ReqnrollMenuTests1
    

A short summary of the feature

@smoke
Scenario Outline: Clicking menu item on main page  should open corresponding page
	Given User opens reqnroll main page
	When I hover on '<menuItem>' menu item
	And I click on '<menuItem>' menu item
	Then Page with '<header>' header should be opened
	Examples: 
	| menuItem      | header                 |
	| Documentation | Reqnroll Documentation |
	| News          | Reqnroll News          |
