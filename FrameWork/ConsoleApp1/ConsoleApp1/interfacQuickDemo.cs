using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp1
{

    interface IOnee
    {
        void Show();
        string Display();
    }
    interface ITwoo
    {
        void Show();
    }
    class Demo : IOnee, ITwoo
    {



        public string Display()
        {
            return "Hello";
        }



        string IOnee.Display()
        {
            throw new NotImplementedException();
        }



        void IOnee.Show()
        {
            throw new NotImplementedException();
        }



        void ITwoo.Show()
        {
            throw new NotImplementedException();
        }

        //OR
        //    public void Show() {//......
        //}



    }
}
class InterfaceQuickDemo
{
}
