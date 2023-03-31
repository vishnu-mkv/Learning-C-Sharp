namespace Assessment2Testing;

[TestClass]
public class LicenseTests
{
    [TestMethod]
    public void FormattingTest1()
    {
        string result = LicensePlate.FormatLicensePlate("5F3Z-2e-9-w", 4);
        Assert.AreEqual(result, "5F3Z-2E9W");
    }

    [TestMethod]
    public void FormattingTest2()
    {
        string result = LicensePlate.FormatLicensePlate("2-5g-3-J", 2);
        Assert.AreEqual(result, "2-5G-3J");
    }

    [TestMethod]
    public void FormattingTest3()
    {
        string result = LicensePlate.FormatLicensePlate("2-4A0r7-4k", 3);
        Assert.AreEqual(result, "24-A0R-74K");
    }

    [TestMethod]
    public void FormattingTest4()
    {
        string result = LicensePlate.FormatLicensePlate("nlj-206-fv", 3);
        Assert.AreEqual(result, "NL-J20-6FV");
    }

    [TestMethod]
    public void GetLicenseTest1()
    {
        int result = LicensePlate.TimeToGetNewLicense("Eric", 2, "Adam Caroline Rebecca Frank");
        Assert.AreEqual(result, 40);
    }

    [TestMethod]
    public void GetLicenseTest2()
    {
        int result = LicensePlate.TimeToGetNewLicense("Zebediah", 1, "Bob Jim Becky Pat");
        Assert.AreEqual(result, 100);
    }

    [TestMethod]
    public void GetLicenseTest3()
    {
        int result = LicensePlate.TimeToGetNewLicense("Aaron", 3, "Jane Max Olivia Sam");
        Assert.AreEqual(result, 20);
    }
}