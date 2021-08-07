using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoading
{
    interface IOne
    {
        int age { get; }
        void Show();
         String Name { get; set; }
    }
    interface ITwo
    {
        string Display();
    }

    class InterfacesDemo : BaseClass, IOne, ITwo
    {
        public int age => throw new NotImplementedException();

        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Show()
        {
            throw new NotImplementedException();
        }

        string ITwo.Display()
        {
            throw new NotImplementedException();
        }
    }
    class InterfaceDemo
    {
        static void Main()
        {
            
        }
    }
}
