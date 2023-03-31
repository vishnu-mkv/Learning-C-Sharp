namespace PracticeTesting;

[TestClass]
public class OverTimeTests
{
    [TestMethod]
    public void TestOverTime1()
    {
        double[] arr = { 9, 17, 30, 1.5 };
        string result = PayCalculator.Calculate(arr);
        Assert.AreEqual("$240.00", result);
    }

    [TestMethod]
    public void TestOverTime2()
    {
        double[] arr = { 16, 18, 30, 1.8 };
        string result = PayCalculator.Calculate(arr);
        Assert.AreEqual("$84.00", result);
    }

    [TestMethod]
    public void TestOverTime3()
    {
        double[] arr = { 13.25, 15, 30, 1.5 };
        string result = PayCalculator.Calculate(arr);
        Assert.AreEqual("$52.50", result);
    }

    [TestMethod]
    public void TestOverTime4()
    {
        double[] arr = { 9, 17, 25, 1.5 };
        string result = PayCalculator.Calculate(arr);
        Assert.AreEqual("$200.00", result);
    }

    [TestMethod]
    public void TestOverTime5()
    {
        double[] arr = { 9, 21, 50, 2.0 };
        string result = PayCalculator.Calculate(arr);
        Assert.AreEqual("$800.00", result);
    }
}
