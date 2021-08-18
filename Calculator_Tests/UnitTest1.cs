using NUnit.Framework;
using Calculator_Model;

namespace Calculator_Tests
{

    public class Tests
    {
        Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Add_Always_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 6;
            var subject = new Calculator { Num1 = 2, Num2 = 4 };
            // Act
            var result = subject.Add();
            // Assert
            Assert.That(result, Is.EqualTo(expectedResult), "optional failure message");
        }
        
        [Test]
        public void GivenX_MutipliedByY_TheResultReturnsCorrect(float x, float y, float expResult)
        {
            _calculator.Num1 = 2;
            _calculator.Num2 = 5;
            Assert.That(_calculator.Add(), Is.EqualTo(7));
        }
    }
}