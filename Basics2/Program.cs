using System;

class Program
{

    static string ExchangeFirstAndLast(string s)
    {

        char[] chars = s.ToCharArray();
        (chars[0], chars[^1]) = (chars[^1], chars[0]);

        return new string(chars);
    }

    static string AddToFirstAndLastOfString(string s)
    {

        return s.Insert(0, ""+s[^1]).Insert(s.Length-1, "" + s[^1]);
    }

    static string RemoveOk(string s)
    {
        return s.Replace("ok", "");
    }

    public static void Main()
    {
        string s = "Hellok";
        Console.WriteLine(ExchangeFirstAndLast(s));
        Console.WriteLine(AddToFirstAndLastOfString(s));
        Console.WriteLine(RemoveOk(s));
    }
}