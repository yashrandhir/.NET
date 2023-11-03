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
______________________________________________________________________________________________________________________________________________________________________________
//Q2 Accept a Float value and print square of it solve above code using Parse,ToSingle,TryParse() and observe exception if you do not enter valid data 

using System;
namespace pr2
{
    class Demo
    {
        public static float Square(float x)
        {
            return x * x;
        }
        public static void Main()
        {
            float o;
            Console.WriteLine("Enter the number");
            float value =float .Parse(Console.ReadLine());
            Console.WriteLine(Square(value));

            Console.WriteLine("Enter the number");
            float value1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(Square(value));

            Console.WriteLine("Enter the number");
            bool b=float.TryParse(Console.ReadLine(), out o);
            if(b==true)
            {
                Console.WriteLine(Square(o));
            }

        }
    }
}
___________________________________________________________________________________________________________________________________________________________________________________


