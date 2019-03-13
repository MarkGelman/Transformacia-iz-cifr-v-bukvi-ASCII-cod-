using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charim
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}", (char)Convert.ToInt32(s[0]), (char)Convert.ToInt32(s[1]), (char)Convert.ToInt32(s[2]), (char)Convert.ToInt32(s[3]), (char)Convert.ToInt32(s[4]), (char)Convert.ToInt32(s[5]), (char)Convert.ToInt32(s[6]));
        }
    }
   
}
