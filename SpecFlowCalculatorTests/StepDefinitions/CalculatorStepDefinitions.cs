using Lab1_SetupUnits;
using NUnit.Framework;
namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class UsingCalculatorStepDefinitions
    {
        private readonly SharedContext _context;

        public UsingCalculatorStepDefinitions(SharedContext context)
        {
            _context = context;
        }

        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            // No need to initialize calculator here
            // It will be handled by SharedContext
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press add")]
        public void WhenIHaveEnteredAndIntoTheCalculator(double p0, double p1)
        {
            _context.Result = _context.Calculator.Add(p0, p1);
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBeOnTheScreen(double expectedResult)
        {
            Assert.That(_context.Result, Is.EqualTo(expectedResult));
        }
    }
}