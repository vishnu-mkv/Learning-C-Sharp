namespace PracticeTesting;

[TestClass]
public class BookTester
{
    [TestMethod]
    public void BookTest1()
    {
        PhotoBook DefaultBook = new PhotoBook();
        Assert.AreEqual(DefaultBook.GetNumberPages(), 16);
    }

    [TestMethod]
    public void BookTest2()
    {
        PhotoBook CustomBook32 = new PhotoBook(32);
        Assert.AreEqual(CustomBook32.GetNumberPages(), 32);
    }

    [TestMethod]
    public void BookTest3()
    {
        BigPhotoBook BigBook = new BigPhotoBook();
        Assert.AreEqual(BigBook.GetNumberPages(), 64);
    }

}