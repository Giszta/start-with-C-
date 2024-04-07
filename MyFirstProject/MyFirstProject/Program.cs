using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constants
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int vat = 20;
            const double percentVAT = vat / 100D;
            //vat = 10;
            Console.WriteLine(vat);

            int balance = 1000;
            Console.WriteLine(balance*percentVAT);

            const string version = "v1.0";

            Console.ReadLine();
        }
    }
}
