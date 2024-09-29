using System;
using TechTalk.SpecFlow;
using Lab1_SetupUnits;
using NUnit.Framework;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class UsingCalculatorDivisionStepDefinitions
    {
        private readonly SharedContext _context;

        public UsingCalculatorDivisionStepDefinitions(SharedContext context)
        {
            _context = context;
        }
      //  [Given(@"I have a calculator")]
      //  public void GivenIHaveACalculator()
      //  {
            // No need to initialize calculator here
            // It will be handled by SharedContext
       // }

        [When(@"I have entered (.*) and (.*) into the calculator and press divide")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDivide(double p0, double p1)
        {
            _context.Result = _context.Calculator.Divide(p0, p1);
        }

        [Then(@"the division result should be (.*)")]
        public void ThenTheDivisionResultShouldBe(double expectedResult)
        {
            Assert.That(_context.Result, Is.EqualTo(expectedResult));
        }

        [Then(@"the division result equals positive_infinity")]
        public void ThenTheDivisionResultEqualsPositiveInfinity()
        {
            Assert.That(_context.Result, Is.EqualTo(double.PositiveInfinity));
        }
    }
}
