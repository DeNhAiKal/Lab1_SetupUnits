Feature: UsingCalculatorFactorial
  In order to calculate the factorial of a number
  As someone who uses a calculator
  I want to use my calculator to calculate factorials

@Factorial
Scenario: Calculating factorial of a positive number
  Given I have a calculator
  When I have entered 5 into the calculator and press factorial
  Then the factorial result should be 120

@Factorial
Scenario: Calculating factorial of zero
  Given I have a calculator
  When I have entered 0 into the calculator and press factorial
  Then the factorial result should be 1

@Factorial
Scenario: Calculating factorial of negative
  Given I have a calculator
  When I have entered -1 into the calculator and press factorial
  Then An exception should be thrown for factorial

@Factorial
Scenario: Calculating factorial of decimal
  Given I have a calculator
  When I have entered 0.5 into the calculator and press factorial
  Then An exception should be thrown for factorial