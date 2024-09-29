Feature: UsingCalculatorMusaLogarithmic
  In order to evaluate system reliability
  As a system quality engineer
  I want to calculate failure intensity and the expected number of failures using the Musa Logarithmic model

@MusaLog
Scenario: Calculate Musa Logarithmic Failure Intensity
  Given I have a calculator
  When I have entered 10 for initial failure intensity, 0.02 for decay parameter, and 50 for failures into the calculator and press Compute Failure Intensity
  Then the failure intensity result should be 3.68 failures/CPU-hour

@MusaLog
Scenario: Calculate Expected Failures using Musa Logarithmic Model
  Given I have a calculator
  When I have entered 10 for initial failure intensity, 0.02 for decay parameter, and 100 for CPU hours into the calculator and press Compute Expected Failures
  Then the expected failures result should be 152 failures
