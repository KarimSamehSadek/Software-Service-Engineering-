using System;
using Xunit;
using Calculator;
using Moq;

namespace CalculatorTest
{
  public class UnitTest1
  {
    [Fact]
    public void CalculationTest()
    {
      var m = new Calc();
      var result = m.Mult(5, 5);
      Assert.Equal(25, result);

    }

    [Fact]
    public void DivisionTest()
    {
      var c = new Calc();
      var result = c.Div(6, 3);
      Assert.Equal(result, 2);
    }
    [Fact]
    public void TestDivideByZero()
    {
      var c = new Calc();
      var result = c.Div(6, 0);
      Assert.Equal(result, -9999);
    }
    [Fact]
    public void PassingTest()
    {
      // var calculator = new ICalculator();
      // Assert.Equal(4, calculator.Multiply(2, 2));
      var calculator = new Mock<ICalculator>();
      calculator.Setup(x => x.Multiply(2, 2)).Returns(4);
      Assert.Equal(4, calculator.Object.Multiply(2, 2));
    }

  }
}
