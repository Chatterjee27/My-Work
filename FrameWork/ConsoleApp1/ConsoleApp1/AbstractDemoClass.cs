using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    abstract class Games
    {

        string name;
        int numOfPlayers;

        public Games()
        {

        }

        public Games(string _name, int _numOfPlayers)
        {
            name = _name;
            numOfPlayers = _numOfPlayers;
        }

        public void Display()
        {
            Console.WriteLine("Demo on Abstract classes....");
        }

        public abstract string ShowGame();

    }

    class Hockey : Games
    {
        public Hockey() { }

        public Hockey(string _name, int _players) : base(_name, _players)
        {

        }
        public override string ShowGame()
        {
            return "National game is Hockey --Chak De";
        }

    }


    class Kabbadi : Games
    {
        public Kabbadi() { }

        public Kabbadi(string _name, int _players) : base(_name, _players)
        {

        }

        public override string ShowGame()
        {
            return "It's Kabbadi --Danga";
        }
    }


    class AbstractClassDemo
    {
        static void Main()
        {
            Hockey hoc = new Hockey("Hockey", 11);
            Console.WriteLine(hoc.ShowGame());

            hoc.Display();

            Games g = new Kabbadi("Kabbadi", 9);
            Console.WriteLine(g.ShowGame());
            g.Display();

            Console.Read();


        }
    }
}
