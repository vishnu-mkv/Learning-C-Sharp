using System;

public class PhotoBook
{
    protected int numPages;

    public PhotoBook()
    {
        numPages = 16;
    }

    public PhotoBook(int numPages)
    {
        this.numPages = numPages;
    }

    public int GetNumberPages()
    {
        return numPages;
    }
}

public class BigPhotoBook : PhotoBook
{
    public BigPhotoBook() : base(64) { }
}

public class PhotoBookTest
{
    public static void Run()
    {
        PhotoBook book1 = new PhotoBook();
        Console.WriteLine("Number of pages in default photo book: " + book1.GetNumberPages());

        PhotoBook book2 = new PhotoBook(32);
        Console.WriteLine("Number of pages in photo book with 32 pages: " + book2.GetNumberPages());

        BigPhotoBook book3 = new BigPhotoBook();
        Console.WriteLine("Number of pages in large photo book: " + book3.GetNumberPages());
    }
}
