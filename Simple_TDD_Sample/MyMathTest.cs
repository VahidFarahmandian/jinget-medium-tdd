using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class MyMathTest
{
    [TestMethod]
    public void Should_return_the_sum_of_two_value()
    {
        int a = 1;
        int b = 2;

        int expectedResult = 3;

        int actualResult = new MyMath().Sum(a, b);

        Assert.AreEqual(expectedResult, actualResult);
    }
}