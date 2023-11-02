//Q1 Accept two numbers from user and do sum of it
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter two numbers");
            string s1=Console.ReadLine();
            string s2=Console.ReadLine();

            bool a1=float.TryParse(s1, out float b1);
            bool a2=float.TryParse(s2, out float b2);

            if( a1 == true && a2 == true )
            {
                Console.WriteLine(b1  + b2);
            }
            else
            {
                Console.WriteLine("Enter the valid data");
            }
        }
    }
}
