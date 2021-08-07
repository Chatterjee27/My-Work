using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConDataTypes
{
    enum Festivals
    {
        DurgaPuja,
        Diwali,
        Holi,
        XMass
    }
    class Program
    {
        int y = 20;
        enum FavMovies
        {
            Intersteller=5,
            Inception,
            ShutterIsland=10,
            BasketBallDiaries,
            TheTheoryOfEverything
        }
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Numeric value of Cyan console color is {0} is",Convert.ToInt32(ConsoleColor.Cyan));
            int x = 10;
            string name = "Zensar";
            Console.WriteLine("The value of x is:"+x +"and the name is:"+ name);
            Console.WriteLine("The value of x is {0} and the value of name is {1}",x,name);
            Console.WriteLine("Enter you EmpID");
            int empId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your name:");
            string ename = Console.ReadLine();
            Console.WriteLine("Enter your gender:");
            char gender = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter your salary:");
            double esal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Your Personal details are as below.");
            Console.WriteLine("EmpId: {0}",empId);
            Console.WriteLine("EmpName: {0}",ename);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Salary: {0}", esal);
            /*ConsoleColor.*/

            Console.WriteLine("Most Fav movie {0}",FavMovies.Inception);
            

            Console.Read();
            /*Console.WriteLine("");*/
        }
    }
}
