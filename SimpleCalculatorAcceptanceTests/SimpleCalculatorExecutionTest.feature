Feature: SimpleCalculatorExecutionTest
	In order to avoid silly mistakes
	As a calculator operator
	I want to be told the result of my calculations

@mytag
Scenario: Test input 1
	Given I have entered 50 into the calculator
	When I enter "C + 3 - 7 +/- sqrt * 5 / 2" into the calculator
	Then the result should be 5 on the screen

Scenario: Test input 2
	Given I have entered 5 into the calculator
	When I enter "C 3 - 7 +/- sqrt * 5 / 2" into the calculator
	Then on the screen should appear error message
