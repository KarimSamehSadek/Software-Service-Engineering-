using System;
using Xunit;
using Calculator;

namespace CalculatorTest
{
  public class UnitTest2
  {
    [Fact]
    public void Test2()
    {
      var m = new Div();
      var result = m.Div(5, 5);
      Assert.Equal(7, result);

    }
  }
}
