using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class UsingCalculatorAvailabilityStepDefinitions
    {
        private readonly SharedContext _context;

        public UsingCalculatorAvailabilityStepDefinitions(SharedContext context)
        {
            _context = context;
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press MTBF")]
        public void WhenIHaveEnteredAndPressMTBF(int MTTF, int MTTR)
        {
            _context.Result = _context.Calculator.CalculateMTBF(MTTF, MTTR);
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press Availability")]
        public void WhenIHaveEnteredAndPressAvailability(int MTTF, int MTTR)
        {
            _context.Result = _context.Calculator.CalculateAvailability(MTTF, MTTR);
        }

        [Then(@"the MTBF result should be ""(.*)""")]
        public void ThenTheMTBFResultShouldBe(double expectedResult)
        {
            Assert.That(_context.Result, Is.EqualTo(expectedResult));
        }

        [Then(@"the availability result should be ""(.*)""")]
        public void ThenTheAvailabilityResultShouldBe(double expectedResult)
        {
            Assert.That(Math.Round(_context.Result, 2), Is.EqualTo(Math.Round(expectedResult, 2)));
        }
    }
}
