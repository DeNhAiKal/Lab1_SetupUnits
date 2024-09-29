Feature: UsingCalculatorAvailability
  In order to calculate MTBF and Availability
  As someone who struggles with math
  I want to be able to use my calculator to do this

  @Availability
  Scenario: Calculating MTBF
    Given I have a calculator
    When I have entered 100 and 20 into the calculator and press MTBF
    Then the MTBF result should be "120"

  @Availability
  Scenario: Calculating Availability
    Given I have a calculator
    When I have entered 100 and 20 into the calculator and press Availability
    Then the availability result should be "0.83"
    
  @Availability
  Scenario: Calculating Availability with large values
    Given I have a calculator
    When I have entered 5000 and 500 into the calculator and press Availability
    Then the availability result should be "0.91"
