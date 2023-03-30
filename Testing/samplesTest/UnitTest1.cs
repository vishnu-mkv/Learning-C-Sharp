namespace samplesTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        Assert.AreEqual(Program.Sum(1, 2), 3);
    }
}