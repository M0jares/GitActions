using TestingGitActions;

namespace MathFunctionsTest
{
    [TestClass]
    public class MathfunctionsTests
    {
        [TestMethod]
        public void Add_ShouldReturnCorrectSum()
        {
            // Arrange
            Mathfunctions math = new Mathfunctions();
            int a = 5;
            int b = 3;
            int expectedSum = 8;

            // Act
            int actualSum = math.Add(a, b);

            // Assert
            Assert.AreEqual(expectedSum, actualSum);
        }

        [TestMethod]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            // Arrange
            Mathfunctions math = new Mathfunctions();
            int a = 10;
            int b = 4;
            int expectedDifference = 6;

            // Act
            int actualDifference = math.Subtract(a, b);

            // Assert
            Assert.AreEqual(expectedDifference, actualDifference);
        }

        [TestMethod]
        public void Multiply_ShouldReturnCorrectProduct()
        {
            // Arrange
            Mathfunctions math = new Mathfunctions();
            int a = 7;
            int b = 2;
            int expectedProduct = 14;

            // Act
            int actualProduct = math.Multiply(a, b);

            // Assert
            Assert.AreEqual(expectedProduct, actualProduct);
        }
    }
}