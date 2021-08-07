using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConDataTypes
{
   class Demo   
    {
        protected int age;
        public string name="Anshul";
       
        internal string city;
        double phoneNo;//default access at class level is private
        private string address;

        public void Show()
        {
            phoneNo = 45454564565;
            address = "Pune";
            age = 34;
        }
    }
    class Display : Demo
    {
        public void DisplayAge()
        {
            age = 22;
            
            
                }
    }
    class D1 : Demo
    {
        public void Dis()
        {
            
        }
    }
    class AccessSpecifiers
    {
        static void Main()
        {
            //Demo d1;
            //d1 = new Demo();
            Demo d = new Demo();
            
            d.city = "Pune";
          
            Console.WriteLine(d.name);
            //d.name = "Vranda";
          ConsoleKeyInfo obj = Console.ReadKey();
            Console.WriteLine(obj);

        }
    }

}

