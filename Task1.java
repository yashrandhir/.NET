*Create a class calculator and write 3 instance method square, cube, round[if in put 22.5 o/p 22]
Which will return square .cube and rounded number.
Create object and call method and print the result.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Calculator
    {
        int a;
        public int Square(int a)
        {
            return a * a;

        }
        public int Cube(int a) 
        {
            return a*a*a;
        }
        public int Round(float a) 
        {
            int c = (int)a;
            return c;
        }

        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            Console.WriteLine(c.Square(10));
            Console.WriteLine(c.Cube(5));
            Console.WriteLine(c.Round(22.5f));
        }
    }
}
