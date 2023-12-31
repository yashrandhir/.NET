1)Create class calculator with two method Add and product. Create object and call method.
using System;
namespace MyFirstProgram
{
    class Calculator
    {
        internal int Add(int a, int b)
        {
            return a + b;
        }
        internal int product(int a, int b)
        {
            return a * b;
        }
    }
    class Demo
    {
        public static void Main()
        {
            Calculator calc = new Calculator();
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();
            calc.Add(int.Parse(num1), int.Parse(num2));
            Console.WriteLine(calc.product(20, 30));
        }
    }
}

2)Create class library with method fact() which will return factorial of a number. Use it in console application
Developer side code and created .dll files
using System
namespace MySecondProgram
{
	class Factorial
	{
		public int fact(int num)
		{
			if(num == 1)
			{
				return 1;
			}
			return num*fact(num-1);
		}
	}
}
namespace ClientDemo
{
	class Demo
	{
		public static void main()
		{
			String string = Console.ReadLine();
			Factorial factorial = new Factorial();
			factorial.fact(int.Parse(string));
		}
	}
}

3)Create a class student in namespace DAC and in namespace DBDA write method add in both class. In entry point call both method
using System;
namespace DAC
{
    public class Student
    {
        String name;
       public Student(string name)
        {
            this.name = name;
        }
       public void add()
        {
            Console.WriteLine("New Student {0} is added in DAC", name);
        }
    }
}
namespace DBDA
{
    class Student 
    {
        String name;
        public Student(string name)
        {
            this.name = name;
        }
        public void add()
        {
            Console.WriteLine("New Student {0} is added in DBDA", name);
        }
    }
}
namespace CollisionDemo
{
    class Demo
    {
        public static void Main()
        {
            DAC.Student student1 = new DAC.Student("Virat Kohli");
            student1.add();

            DBDA.Student student2 = new DBDA.Student("ABD");
            student2.add();
        }
    }
}
			
