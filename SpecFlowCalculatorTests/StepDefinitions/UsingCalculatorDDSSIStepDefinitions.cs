using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class UsingCalculatorDDSSI
    {
        private readonly SharedContext _context;

        public UsingCalculatorDDSSI(SharedContext context)
        {
            _context = context;
        }

        [When(@"I have entered (.*) for defects and (.*) for KSSI into the calculator and press Compute Defect Density")]
        public void WhenIHaveEnteredForDefectsAndForKSSIIntoTheCalculatorAndPressComputeDefectDensity(int defects, double kssi)
        {
            _context.Result = _context.Calculator.CalculateDefectDensity(defects, kssi);
        }

        [Then(@"the defect density result should be (.*) defects per KSSI")]
        public void ThenTheDefectDensityResultShouldBe(double expectedResult)
        {
            Assert.That(_context.Result, Is.EqualTo(expectedResult));
        }

        [When(@"I have entered (.*) for first release KSSI, (.*) for added KCSI, (.*) for deleted KSSI, and (.*) for changed KSSI into the calculator and press Compute Total SSI")]
        public void WhenIHaveEnteredForFirstReleaseKSSIAndForAddedKCSIAndForDeletedKSSIAndForChangedKSSIIntoTheCalculatorAndPressComputeTotalSSI(double firstReleaseKSSI, double addedKCSI, double deletedKSSI, double changedKSSI)
        {
            _context.Result = _context.Calculator.CalculateSSI(firstReleaseKSSI, addedKCSI, deletedKSSI, changedKSSI);
        }

        [Then(@"the total SSI result should be (.*) KSSI")]
        public void ThenTheTotalSSIResultShouldBe(double expectedResult)
        {
            Assert.That(_context.Result, Is.EqualTo(expectedResult));
        }
    }
}
