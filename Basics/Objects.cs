using System;

namespace Basics
{

    internal class Objects
    {
        string name;
        public Objects(string name)
        {
            this.name = name;
        }
        public static void Print()
        {
            Console.WriteLine("Static method triggered");
        }
    }

}