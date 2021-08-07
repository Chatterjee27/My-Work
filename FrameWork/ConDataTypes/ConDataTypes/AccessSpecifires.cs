using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConDataTypes
{
    class Demo //the access at namespace level is internal
    {
        protected int age;
        public string name = "Giorgio";
        internal string city;
        internal int a = 1;
        double phoneNo;//deafult access of class level is private
        private string address;

        public void Show()
        {
            phoneNo = 5445644564564 ;
            address = "Pune" ;
            age = 22;
        }
    }
    class Display : Demo
    {
        public void DisplayAge()
        {
            age = 25;
        }
    }

    class D1 : Demo
    {
        public void Dis()
        {
            
        }
    }

    class AccessSpecifires
    {
        static void Main()
        {
            Demo d1;
            d1 = new Demo();

            Demo d = new Demo();
            d.city = "Pune";

            Console.WriteLine(d.city);
            Console.WriteLine(d.a);
            ConsoleKeyInfo obj = Console.ReadKey();
            Console.WriteLine(obj);
        }
    }
}
