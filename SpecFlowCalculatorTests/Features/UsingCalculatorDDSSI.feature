Feature: UsingCalculatorDDSSI
  In order to assess system quality and track releases
  As a system quality engineer
  I want to calculate the defect density and the total number of Shipped Source Instructions (SSI) for successive releases

@DDSSI
Scenario: Calculate Defect Density
  Given I have a calculator
  When I have entered 100 for defects and 50 for KSSI into the calculator and press Compute Defect Density
  Then the defect density result should be 2.0 defects per KSSI

@DDSSI
Scenario: Calculate Total SSI for Successive Releases
  Given I have a calculator
  When I have entered 50 for first release KSSI, 20 for added KCSI, 4 for deleted KSSI, and 10 for changed KSSI into the calculator and press Compute Total SSI
  Then the total SSI result should be 56 KSSI
