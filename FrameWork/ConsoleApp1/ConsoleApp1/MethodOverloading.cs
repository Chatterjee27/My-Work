using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Calculator
    {
        public int Add(int x , int y)
        {
            return x + y;
        }

        public void Add()
        {
            Console.WriteLine("Add method without parameter");
        }

        public void Add(string str, int x)
        {
            Console.WriteLine(str + x);
        }
        public void Add(int a, string str)
        {
            Console.WriteLine( str + a );
        }

        

    }
    class MethodOverloading
    {
        static void Main()
        {
            Calculator calc = new Calculator();
            calc.Add();
        }
    }
}
