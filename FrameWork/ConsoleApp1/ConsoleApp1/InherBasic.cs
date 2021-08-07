using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp1
{
    class Person
    {
        int age;
        string fname;
        string lname;
        string city;



        public Person()
        {



        }
        public Person(string _fname, string _lname, int _age, string _city)
        {
            fname = _fname;
            lname = _lname;
            age = _age;
            city = _city;

        }



        public void DisplayPerson()
        {
            Console.WriteLine("Personal Details.....");
            Console.WriteLine("---------------------");
            Console.WriteLine("FullName : {0} {1}", fname, lname);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("City: {0}", city);
        }

    }
    class Employee : Person
    {
        int empId;
        string deptName;
        double eSal;



        public Employee()
        {



        }
        public Employee(string firstName, string _lname, int age, string _city, int eid, string dName, double sal)
            : base(firstName, _lname, age, _city)
        {
            empId = eid;
            deptName = dName;
            eSal = sal;
        }

        public void DisEmp()
        {
            Console.WriteLine("Employee Details.....");
            Console.WriteLine("---------------------");
            Console.WriteLine("EmpId : {0}", empId);
            Console.WriteLine("Dept Name : {0}", deptName);
            Console.WriteLine("City: {0}", eSal);
        }
    }
    class InheriBasics
    {
        static void Main()
        {
            Employee emp = new Employee("Sayantan","Chatterjee",22,"Barcelona",89424,"TechTrainning",50000);
            emp.DisplayPerson();
            emp.DisEmp();

            Console.Read();
        }
    }
}