using Lab1_SetupUnits;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.stepDefinitions
{
    [Binding]
    public class Hooks
    {
        private readonly ScenarioContext _scenarioContext;

        public Hooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void InitializeCalculator()
        {
            _scenarioContext["Calculator"] = new Calculator();
        }
    }

}
