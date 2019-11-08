using System;
using Xunit;
using Calculator;

namespace CalculatorTest
{
  public class UnitTest1
  {
    [Fact]
    public void Test1()
    {
      var m = new Calc();
      var result = m.Mult(5, 5);
      Assert.Equal(25, result);

    }



  }
}
