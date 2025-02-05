using System.Text;
using Game;
using System.Threading;
using System;
using System.IO;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;

public static class File { };

class Program
{

    static void Main(string[] args)
    {
        

        Assassin player1 = new Assassin("HoWL", 40, 15, 4, 15, 20, 30, (Race)1);
        player1.print();
        Console.WriteLine();
        List<string> a = new List<string>();
        a.Add("Bow");
        a.Add("Roten meat");
        Mob player2 = new Mob("Anton", 15, 150, 7, 10, 30, a);

        Console.WriteLine();
        Thread.Sleep(000);
        while (true)
        {
            Console.WriteLine();
            Thread.Sleep(000);

            if (player1.attack(player2))
                break;
            Console.WriteLine();
            Thread.Sleep(000);
        }
    }
}
