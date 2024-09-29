using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class UsingCalculatorMusaLogarithmic
    {
        private readonly SharedContext _context;

        public UsingCalculatorMusaLogarithmic(SharedContext context)
        {
            _context = context;
        }

        [When(@"I have entered (.*) for initial failure intensity, (.*) for decay parameter, and (.*) for failures into the calculator and press Compute Failure Intensity")]
        public void WhenIHaveEnteredForInitialFailureIntensityAndForDecayParameterAndForFailuresIntoTheCalculatorAndPressComputeFailureIntensity(double initialIntensity, double decayParameter, double failures)
        {
            _context.Result = _context.Calculator.CalculateMusaFailureIntensity(initialIntensity, decayParameter, failures);
        }

        [Then(@"the failure intensity result should be (.*) failures/CPU-hour")]
        public void ThenTheFailureIntensityResultShouldBe(double expectedResult)
        {
            Assert.That(_context.Result, Is.EqualTo(expectedResult));
        }

        [When(@"I have entered (.*) for initial failure intensity, (.*) for decay parameter, and (.*) for CPU hours into the calculator and press Compute Expected Failures")]
        public void WhenIHaveEnteredForInitialFailureIntensityAndForDecayParameterAndForCPUHoursIntoTheCalculatorAndPressComputeExpectedFailures(double initialIntensity, double decayParameter, double cpuHours)
        {
            _context.Result = _context.Calculator.CalculateMusaExpectedFailures(initialIntensity, decayParameter, cpuHours);
        }

        [Then(@"the expected failures result should be (.*) failures")]
        public void ThenTheExpectedFailuresResultShouldBe(double expectedResult)
        {
            Assert.That(_context.Result, Is.EqualTo(expectedResult));
        }
    }
}
