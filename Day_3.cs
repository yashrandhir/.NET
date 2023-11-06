/*1) Create a Student class with member variables name, maths, science, eng.
create a method which will return total marks [300]
create a method which will display name and total.*/
using System;
namespace Demo
{

  public class Student
    {
        string Name;
        int Maths;
        int Science;
        int Eng;
        int Marks;

        public Student(string name, int maths, int science, int eng)
        {
          this.Name = name;
           this.Maths = maths;
          this.Science = science;
          this.Eng = eng;
           
        }
        public void Totalmarks()
        {
            Marks = Maths + Science + Eng;
        }
        public string Display()
        {
           Totalmarks();
            return String.Format("Name = {0} Total ={1} out of 300", Name, Marks);
        }
    }
    public class Yash
    {
        public static void Main()
        {
            Student student1 = new Student("Bapu",50,60,98);
            Student student2 = new Student("appa",90, 70, 60);
            Console.WriteLine("Info about Student1 is" + student1.Display());
            Console.WriteLine("Info about Student2 is"+ student2.Display());
        }
    }

}
_____________________________
