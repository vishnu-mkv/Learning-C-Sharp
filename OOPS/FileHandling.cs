using System.Text;

internal class FileHandling
{
    public static void Run()
    {
        Console.WriteLine("Inside File Handling");
        FileStream file = new FileStream(
            "C:\\Users\\Star\\Desktop\\filename1.txt",
            FileMode.OpenOrCreate,
            FileAccess.ReadWrite);

        file.WriteByte(66);
        Stream stream = new MemoryStream();
        String strText = "This is a String that needs to be convert in stream";
        byte[] byteArray = Encoding.UTF8.GetBytes(strText);
        file.Write(byteArray);

        file.Close();
        var p = "C:\\Users\\Star\\Desktop\\filename1.txt";
        File.AppendAllText(p, "This is X!");

        const string path = "C:\\Users\\Hp\\Documents\\file.txt";
        using (TextWriter textWriter = File.CreateText(path))
        {
            char[] charArray = { 'h', 'e', 'l', 'l', 'o' };
            textWriter.WriteLine(charArray, 2, 3);
        }

        using (TextReader textReader = File.OpenText(path))
        {
            Console.WriteLine(textReader.Read());
        }
    }
}