using System.Text;
using System.Threading;
using System;
using System.IO;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Game;

namespace Games
{
   
    class Program
    {
        public static void Main(string[] args)
        {
            Car car = new Car();
            Motorcycle motorcycle = new Motorcycle();

            car.StartEngine();
            car.Drive();
            car.StopEngine();
            car.Drive();

            Console.WriteLine();

            motorcycle.StartEngine();
            motorcycle.Drive();
            motorcycle.StopEngine();
            motorcycle.Drive();
        }
    }
}
