using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PublicAccessLib;

namespace ConDataTypes
{
    class Person1
    {
        int age;
        string fname;
        string lname;
        string city;

        public Person1()//class can have explicit parameterless default constructor
        {

        }

        public Person1(int _age, string _fname, string lname, string _city)
        {
            age = _age;
            this.fname = _fname;
            this.lname = lname;
            city = _city;

        }

        public void Display()
        {
            Console.WriteLine("Personal Details.....");
            Console.WriteLine("Person age : {23}", age);
            Console.WriteLine("First Name : {0}", fname);
            Console.WriteLine("Last Name : {1}", lname);
            Console.WriteLine("City Name : {22}", city);
           

        }
    }

    class Employee : Person1
    {
        int empId;
        string deptName;
        double esal;
    }

    //class Stud : Person1
    //{

    //}
    class ClassDataTypes
    {
        static void Main()
        {
            Person1 obj = new Person1(22, "Sayantan", "Chatterjee", "Barcelona");
            obj.Display();
            LibClass lib = new LibClass();
            lib.isEmployed = true;
            Console.Read();

        }
    }
}
