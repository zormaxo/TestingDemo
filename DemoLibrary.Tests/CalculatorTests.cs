namespace DemoLibrary.Tests;

public class CalculatorTests
{
    [Fact]
    public void Add_SimpleValuesShouldCalculate()
    {
        // Arrange
        double expected = 5;

        // Act
        double actual = Calculator.Add(2, 3);

        // Assert
        Assert.Equal(expected, actual);
    }
}
