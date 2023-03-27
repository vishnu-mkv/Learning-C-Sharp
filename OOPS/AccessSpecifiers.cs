using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class AccessSpecifiers
    {
        private string name = "X!";
        protected internal void Display(string msg)
        {
            Console.WriteLine(msg);
            //Console.WriteLine(name);
        }
    }
}