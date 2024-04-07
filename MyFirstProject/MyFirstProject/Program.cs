using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = 10;
            int numberTwo = 2;
            int remainder = numberOne % numberTwo;
            Console.WriteLine(remainder);
            numberOne = 11;
            remainder = numberOne % numberTwo;
            Console.WriteLine(remainder);

            Console.ReadLine();
        }
    }
}
