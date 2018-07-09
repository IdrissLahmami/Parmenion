Feature: CalculatorFeature
	 In order to avoid silly mistakes 
	As a math idiot
	I want to be told the sum of two numbers


@Browser_Chrome
@UILevel
Scenario Outline: Divide Two Numbers at UI level
	Given I navigated to /
	And I have entered <Number 1> into Numerator calculator
	And I have entered <Number 2> into Denominator calculator
	When I press divide
	Then the result should be <Result> on the screen

Scenarios: Number is positive
	| Number 1	| Number 2	| Result	|
	| 18		| 3			| 6			|
	| 32.60		| 2.00		| 16.30		| 
	| 10.45		| 2.3509	| 4.4451061295674  |

Scenarios: Number is negative
	| Number 1 | Number 2 | Result |
	| 0        | 0		  | NaN    |
	| A        | B        | NaN    |
	|-1	       | 0		  | -∞	   |


@Browser_Chrome
@APILevel
Scenario Outline: Divide Two Numbers at Api level
	Given I navigated to /
	And I have entered <Number1> into Numerator calculator
	And I have entered <Number2> into Denominator calculator
	When I press divide
	Then the result should be <Result> on the screen
	
Scenarios: Number is positive
	| Number1	| Number2 | Result	|
	| 24		| 6		  | 4			|
