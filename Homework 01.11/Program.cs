using System.Text;
using Game;
using System.Threading;
using System;
using System.IO;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Diagnostics;
using System.Drawing;

public static class File { };

class Program
{
    static void DrawBoard(Point chessman, Point[] posibleMoves)
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                var currentPoint = new Point(j, i);
                if (chessman == currentPoint) Console.BackgroundColor = ConsoleColor.Red;
                else if (Array.IndexOf(posibleMoves, currentPoint) != -1)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.BackgroundColor = Convert.ToBoolean((j + i) % 2) ? ConsoleColor.DarkGray : ConsoleColor.Gray;
                }
                Console.Write("  ");
                Console.ResetColor();
            }
            Console.WriteLine();
        }
        Console.ResetColor();
    }

    static void Main(string[] args)
    {
        int a, b;
        Console.WriteLine("Points:");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());


        Ferzin ferzin = new Ferzin(a - 1, b - 1, team.white);
        int[][] n = ferzin.whereCanMove();
        Point[] points = new Point[n.Length];
        for (int i = 0; i < n.Length; i++)
        {
            points[i] = new Point(n[i][1], n[i][0]);
        }
        Point c = new Point(a - 1, b - 1);
        DrawBoard(c, points);

        Console.WriteLine(ferzin.isCanMove(1, 2)); // значение нужно задавать с 0 до 7 
    }
}


