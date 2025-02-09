using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Game
{
    public interface IDrivable
    {
        bool isStarted { get; set; }
        public void StartEngine();
        public void StopEngine();
        public void Drive();
    }

    public class Car : IDrivable
    {
        public bool isStarted { get; set; }
        public void StartEngine()
        {
            this.isStarted = true;
            Console.WriteLine("The car engine was started");
        }

        public void StopEngine()
        {
            this.isStarted = false;
            Console.WriteLine("The car engine was stoped");
        }

        public void Drive()
        {
            if (this.isStarted)
                Console.WriteLine("The car is driving");
            else
                Console.WriteLine("The engine is turned off, the car does not drive");
        }
    }
    public class Motorcycle : IDrivable
    {
        public bool isStarted { get; set; }
        public void StartEngine()
        {
            this.isStarted = true;
            Console.WriteLine("The motorcycle engine was started");
        }

        public void StopEngine()
        {
            this.isStarted = false;
            Console.WriteLine("The motorcycle engine was stoped");
        }

        public void Drive()
        {
            if (this.isStarted) 
                Console.WriteLine("The motorcycle is driving");
            else 
                Console.WriteLine("The engine is turned off, the motorcycle does not drive");
        }
    }

}
