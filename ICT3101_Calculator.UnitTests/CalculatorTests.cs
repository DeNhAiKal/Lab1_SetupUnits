using Lab1_SetupUnits;

namespace ICT3101_Calculator.UnitTests
{
    public class CalculatorTests
    {
        private Calculator _calculator;
        [SetUp]
        public void Setup()
        {
            // Arrange
            _calculator = new Calculator();
        }
        [Test]
        public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Add(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(30));
        }
        [Test]
        public void Subtract_WhenSubtractingTwoNumbers_ResultEqualToDifference()
        {
            //Act
            double result = _calculator.Subtract(20, 10);
            //Assert
            Assert.That(result, Is.EqualTo(10));
        }
        [Test]
        public void Multiply_WhenMultiplyingTwoNumbers_ResultEqualToProduct()
        {
            //Act
            double result = _calculator.Multiply(5, 4);
            //Assert
            Assert.That(result, Is.EqualTo(20));
        }
        [Test]
        public void Divide_WhenDividingTwoNumbers_ResultEqualToQuotient()
        {
            //Act
            double result = _calculator.Divide(10, 2);
            //Assert
            Assert.That(result, Is.EqualTo(5));
        }
        [Test]
        [TestCase(0, 0, 1)]
        [TestCase(0, 10, 0)]
        [TestCase(10, 0, double.PositiveInfinity)]
        public void Divide_WithZerosAsInputs_ResultHandlesSpecialCases(double a, double b, double expectedResult)
        {
            if (b == 0 && a != 0)
            {
                // For cases where the denominator is zero but numerator is not zero, expect positive infinity.
                var result = _calculator.Divide(a, b);
                Assert.That(result, Is.EqualTo(expectedResult));
            }
            else if (b == 0 && a == 0)
            {
                // Special case: 0 / 0 should return 1.
                var result = _calculator.Divide(a, b);
                Assert.That(result, Is.EqualTo(expectedResult));
            }
            else
            {
                // Regular division
                var result = _calculator.Divide(a, b);
                Assert.That(result, Is.EqualTo(expectedResult));
            }
        }


        [Test]
        public void Factorial_WhenGivenPositiveNumber_ResultFactorial()
        {
            //Act
            double result = _calculator.Factorial(5);
            //Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void Factorial_WhenGivenZero_ResultOne()
        {
            //Act
            double result = _calculator.Factorial(0);
            //Assert
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void Factorial_WhenGivenNegativeNumber_ResultThrowsArgumentException()
        {
            // Assert
            Assert.That(() => _calculator.Factorial(-5), Throws.ArgumentException);
        }
        [Test]
        public void TriangleArea_WhenGivenLengthAndHeight_ResultCorrectArea()
        {
            // Arrange
            double height = 10;
            double length = 5;
            // Act
            double result = _calculator.TriangleArea(height, length);
            // Assert
            Assert.That(result, Is.EqualTo(25)); 
        }
        [Test]
        public void CircleArea_WhenGivenRadius_ResultCorrectArea()
        {
            // Arrange
            double radius = 5;
            // Act
            double result = _calculator.CircleArea(radius);
            // Assert
            Assert.That(result, Is.EqualTo(Math.PI * 25));  
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(60));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(5));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(4, 5), Throws.ArgumentException);
        }
        [Test]
        public void GenMagicNum_ValidInput_ReturnsCorrectResult()
        {
            // Arrange: Create a test file
            IFileReader fileReader = new FileReader(); 
            File.WriteAllLines("MagicNumbers.txt", new string[] { "10", "20", "30", "40" });

            // Act
            double result = _calculator.GenMagicNum(2, fileReader);  // Injected// Index 2 corresponds to 30

            // Assert
            Assert.AreEqual(60, result);  // Since 30 * 2 = 60
        }
        [Test]
        public void GenMagicNum_InvalidInput_ReturnsNegativeResult()
        {
            // Arrange: Create a test file
            IFileReader fileReader = new FileReader();
            File.WriteAllLines("MagicNumbers.txt", new string[] { "10", "20", "30", "40" });

            // Act
            double result = _calculator.GenMagicNum(-1, fileReader); // Invalid input, expect 0

            // Assert
            Assert.AreEqual(0, result);  // Expect a negative result to be handled
        }
        [Test]
        public void GenMagicNum_OutOfRange_ReturnsDefaultValue()
        {
            // Arrange: Create a test file
            IFileReader fileReader = new FileReader(); 
            File.WriteAllLines("MagicNumbers.txt", new string[] { "10", "20", "30", "40" });

            // Act
            double result = _calculator.GenMagicNum(5, fileReader); // Index 5 is out of range

            // Assert
            Assert.AreEqual(0, result);  // Expect default behavior (no result)
        }
    }
}