using Lab1_SetupUnits;
using NUnit.Framework;
using System;
using System.Diagnostics;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.CommonModels;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class UsingCalculatorBasicMusaStepDefinitions
    {
        private readonly SharedContext _context;

        public UsingCalculatorBasicMusaStepDefinitions(SharedContext context)
        {
            _context = context;
        }
        [When(@"I have entered (.*) for initial intensity and (.*) average number of failures and (.*) total number of failures into the calculator and press Current Failure Intensity")]
        public void WhenIHaveEnteredForInitialIntensityAndAverageNumberOfFailuresAndTotalNumberOfFailuresIntoTheCalculatorAndPressCurrentFailureIntensity(int initialIntensity, int averageFailures, int totalNumberFailures)
        {
            _context.Result = _context.Calculator.CalculateCurrentFailureIntensity(initialIntensity, averageFailures, totalNumberFailures);
        }

        [Then(@"the current failure intensity result should be ""([^""]*)""")]
        public void ThenTheCurrentFailureIntensityResultShouldBe(double expectedResult)
        {
            Assert.That(_context.Result, Is.EqualTo(expectedResult));
        }

        [When(@"I have entered (.*) for total failures over infinite time, (.*) for initial intensity, and (.*) for time into the calculator and press Average Expected Failures")]
        public void WhenIHaveEnteredForTotalFailuresOverInfiniteTimeForInitialIntensityAndForTimeIntoTheCalculatorAndPressAverageExpectedFailures(int totalFailures, int initialIntensity, int time)
        {
            _context.Result = _context.Calculator.CalculateAverageExpectedFailures(totalFailures, initialIntensity, time);
        }

        [Then(@"the average expected failures result should be ""([^""]*)""")]
        public void ThenTheAverageExpectedFailuresResultShouldBe(double expectedResult)
        {
            Assert.That(_context.Result, Is.EqualTo(expectedResult));
        }
    }
}

