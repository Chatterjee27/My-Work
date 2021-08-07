using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConInheritance
{
    class Vehicle
    {
        string color;
        int noOfWheels;
        string model;
        string make;

        //long hand notation for creating properties 
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string Make
        {
            get { return make; }
            //set { make = value; }

        }

        public int NoOfWheels
        {
            get { return noOfWheels; }
            set
            {
                if (value < 2)
                {
                    Console.WriteLine("Wheels for a vechiles should have min 2 wheels");
                }
                else
                {

                    noOfWheels = value;
                }
            }
        }
        // auto implemted or automatic properties inroduced in 3.0/3.5 Frmework
        public string Model { get; set; }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle veh = new Vehicle();
            veh.Color = "Red";
            Console.WriteLine(veh.Color);
            //veh.Make = "TATA";
            Console.WriteLine(veh.Make);
            veh.NoOfWheels = 2;
            //veh.NoOfWheels = 1;
            Console.WriteLine(veh.NoOfWheels);
            Console.Read();
        }
    }
}