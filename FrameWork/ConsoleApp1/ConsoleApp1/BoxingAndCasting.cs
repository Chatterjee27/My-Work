using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoading
{
    class Base1
    {

    }

    sealed class D1 : Base1
    {

    }
    //class D2 : D1
    //{
    //class D1
    //}


    // sealed method example

    class B1
    {
        public sealed virtual void Demo()
        {
            Console.WriteLine("Virtual method of base class B1");
        }
    }

    class Del1 : B1
    {
        public override void Demo()
        {

            Console.WriteLine("overriden method of base class B1");
        }
    }
    class Del2 : Del1
    {
        public override void Demo()
        {
            Console.WriteLine("Overriden method of base class B1");
        }
    }
    class BoxingAndCasting
    {
        static void Main()
        {
            int x = 10;//x is a value type
            Object obj; // obj is a referecnce type;
            obj = x; //in this line I have conveterd ref value to ref type;

            Console.WriteLine("Value of ref type obj is{0} and value of value type x is : {1}", obj, x);

            //unboxing

            Object obj1 = 20; //obj1 is ref type

            int y;//here y in integer and it is a value type

            y = (int)obj1;//This is unbxing 

            Console.WriteLine("value of y after uboxing: {0} ", y);

            //implicit casting

            int a = 10; //value type
            double d; //value

            d = a; // double(a);Pointing (INT) to d which is of type double

            //This above line is doing implicit casting

            Console.WriteLine("the value of d after implicit type casting is : {0}", d);

            //explicit casting

            double d1 = 100.23;//vlaue type

            int b;//value type

            b = (int)d1;//explicit casting

            Console.WriteLine("The value of b after explicit typecasting : {0}", b);

            Console.Read();
        }
    }
}
