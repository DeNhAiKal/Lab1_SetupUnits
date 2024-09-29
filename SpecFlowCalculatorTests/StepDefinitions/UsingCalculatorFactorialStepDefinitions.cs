using Lab1_SetupUnits;
using NUnit.Framework;

[Binding]
public class UsingCalculatorFactorialStepDefinitions
{
    private readonly ScenarioContext _scenarioContext;
    private double _result;
    private string _exceptionMessage;

    public UsingCalculatorFactorialStepDefinitions(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    [When(@"I have entered (.*) into the calculator and press factorial")]
    public void WhenIHaveEnteredIntoTheCalculatorAndPressFactorial(double number)
    {
        try
        {
            var calculator = (Calculator)_scenarioContext["Calculator"];
            _result = calculator.Factorial(number);
        }
        catch (ArgumentException ex)
        { 
        _exceptionMessage = ex.Message;
        }
    }

    [Then(@"the factorial result should be (.*)")]
    public void ThenTheFactorialResultShouldBe(double expectedResult)
    {
        Assert.That(_result, Is.EqualTo(expectedResult));
    }
    [Then(@"An exception should be thrown for factorial")]
    public void ThenAnExceptionShouldBeThrownForFactorial()
    {
        Assert.That(_exceptionMessage, Is.Not.Null);
    }

}