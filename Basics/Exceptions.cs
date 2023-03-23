using System;

namespace Basics
{
    internal class Exceptions
    {
        public static void UserDefinedException()
        {
            int x = 5, y = 0;
            int z;
            try
            {
                z = x / y;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {

            }
        }

    }
}