using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ArrayInCsharp
    {

        static void Main()
        {
            Array arr = new int[4];
            //arr.length=10;
            Console.WriteLine(arr.Length);
            Array arr1 = new string[3];
            Array arr2 = Array.CreateInstance(typeof(char), 5);
            
            int[] a1 = new int[5];

            String[] s = { "Misbah", "Temu" ,"Gg", "Donapapa", "Adnoor"};
            
            for(int i=0; i<s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }
            foreach(string n in s)
                Console.WriteLine(n);

            Console.Read();
        }
    }
}
