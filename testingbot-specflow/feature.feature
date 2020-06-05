Feature: Calculator

Scenario Outline: Can do simple math
	Given I am using the calculator
	When I add inputA for "5"
	When I add inputB for "10"
	Then I should see the sum "15"