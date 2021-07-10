using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class MyMathTest
{
    [TestMethod]
    public void Should_return_result_with_negative_power()
    {
        decimal number = 2;
        decimal raiseToPower = -3;

        decimal expectedResult = 0.125M;

        decimal actualResult = new MyMath().Pow(number, raiseToPower);

        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void Should_return_result_with_positive_power()
    {
        decimal number = 2;
        decimal raiseToPower = 3;

        decimal expectedResult = 8;

        decimal actualResult = new MyMath().Pow(number, raiseToPower);

        Assert.AreEqual(expectedResult, actualResult);
    }
}
