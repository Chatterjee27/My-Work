using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConDataTypes
{
    enum Festivals
    {
        Diwali,
        Eid,
        Holi,
        XMass,
        DurgaPooja
    }

  
    class Program
    {
        int y = 20;
        enum FavMovies
        {
            Singham=5,
            Drisyam=7,
            Dus=10,
            ChennaiExpress=12,
            JollyLLB=1


        }

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Numeric value of cyan console color is {0}",
                Convert.ToInt32( ConsoleColor.Cyan));
            int x = 10;
            string name = "Zensar";
            Console.WriteLine("The value of x is:"+x +" and name is :"+name);
            Console.WriteLine("The value of x is {0} and name is {1}",x,name);
            Console.WriteLine("Enter you EmpID");
            long empId = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter your name");
            string ename = Console.ReadLine();
            Console.WriteLine("Enter the char for your gender");
            char gender = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter your salary...");
            double esal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Your Personal details are as below:");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("EmpId: {0}\n EmpName {1} ",empId,ename);
            Console.WriteLine("EmpName: {0}", ename);
            Console.WriteLine("Gender:{0}",gender);
            Console.WriteLine("Salary:{0}",esal);

            Console.WriteLine("Most Fav movie {0}", FavMovies.Drisyam);
            
          
            




            Console.Read();

        }
    }
}
