using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConDataTypes
{
    struct Person
    {

    }
    struct Student //:Person
    {
        //public int rollNo;
        //public string name;
        //public double marks;

        int age;
        bool isEmployed;
        string instName;
        
        public Student(int _age, bool _isEmployed, string _instName)
        {
            this.age = _age;
            isEmployed = _isEmployed;
            instName = _instName;
        }

        public void Show()
        {
            Console.WriteLine("Enter RollNo, Name and marks in order");
            int rollNo = Convert.ToInt32(Console.ReadLine());
            string name = Console.ReadLine();
            double marks = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Student details of rollNo {0}" , rollNo);

            Console.WriteLine("Name :{0} and Marks : {1}",name,marks);

            Console.WriteLine();
        }
    }
    class StructDemo
    {
        static void Main()
        {
            Student stud= new Student(23,true,"JIS");
            Console.ReadLine();
            stud.Show();
            
            Console.ReadLine();
        }
    }
}
