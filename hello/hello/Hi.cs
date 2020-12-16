using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello
{
    partial class Hi
    {
        void hi()
        {
            Console.WriteLine("Hi");
        }
        static void Main(string[] args)
        {
            Hi h = new Hi();
            h.hi();


        }
    }
}
