Feature: UsingCalculatorBasicMusa
  In order to calculate the Basic Musa model's failures/intensities
  As a Software Quality Metric enthusiast
  I want to use my calculator to do this

@Musa
  Scenario: Calculating Current Failure Intensity
    Given I have a calculator
    When I have entered 10 for initial intensity and 30 average number of failures and 100 total number of failures into the calculator and press Current Failure Intensity
    Then the current failure intensity result should be "7"

@Musa
  Scenario: Calculating Average Number of Expected Failures
    Given I have a calculator
    When I have entered 200 for total failures over infinite time, 100 for initial intensity, and 5 for time into the calculator and press Average Expected Failures
    Then the average expected failures result should be "183.58"
