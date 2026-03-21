Feature: ReqnrollMenuTests
    In order to easily find needed test documentation
	As a reqnroll user
	I want to be able to navigate to pages through main menu

A short summary of the feature

@smoke
Scenario: Clicking on "Documentation" menu item should open documentation page
	Given User opens reqnroll main page
	When I hover on 'Documentation' menu item
	And I click on 'Documentation' menu item
	Then Page with 'Reqnroll Documentation' header should be opened

Scenario Outline: Clicking menu item on main page  should open corresponding page
	Given User opens reqnroll main page
	When I hover on '<menuItem>' menu item
	And I click on '<menuItem>' menu item
	Then Page with '<header>' header should be opened
	Examples: 
	| menuItem      | header                 |
	| Documentation | Reqnroll Documentation |
