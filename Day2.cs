//Q1 Accept two numbers from user and do sum of it
using System;
namespace problem1
{
    class Demo
    {
        public static void Main(string[] args)
        {
            int num1=int.Parse(Console.ReadLine()); 
            int num2=int.Parse(Console.ReadLine());
            
            Console.WriteLine("Addition of two numbers {0} and {1} is {2}",num1,num2,num2+num1);
        }
    }
}
