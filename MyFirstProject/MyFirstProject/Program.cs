using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Operations

{
    internal class Program
    {
        static void Main(string[] args)
        {

            int age = 23;
            age++;
            Console.WriteLine(age);
            age--;
            Console.WriteLine(age);
            age *= 10;
            age += 10;
            double age2 = 23;
            age2 /= 10;
            Console.WriteLine(age2);

            string name = "Aba";
            name += " is programing!";
            Console.WriteLine(name);

            char ch = 'a';
            ch += 'b';
            Console.WriteLine(ch);

            int i = 0;
            Console.WriteLine(i++);
            Console.WriteLine(i);
            Console.WriteLine(++i);

            Console.ReadLine();
        }
    }
}
