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

        public Person1() // class can have explicit parameterless constructors
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
            Console.WriteLine("Personal Details......");
            Console.WriteLine("First Name : {0}", fname);
            Console.WriteLine("Last Name : {0}", lname);
            Console.WriteLine("Age in years : {0}", age);
            Console.WriteLine("City : {0}", city);
        }


    }

    class Employee : Person1
    {
        int empId;
        string deptName;
        double esal;

    }


   

    class ClassAsDataType
    {
        static void Main()
        {
            Person1 objPer = new Person1(22, "Shriya", "Nair", "Munnar");
            objPer.Display();
            LibClass lib = new LibClass();
            lib.isEmployed = true;
            
            Console.Read();
        }
    }

}

