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
    class dateForCard
    {
        int year;
        int month;

        public int Month { get { return this.month; } }
        public int Year { get { return this.year; } }

        public override string ToString()
        {
            return $"{month}.{year}";
        }

        public dateForCard(int year, int month)
        {
            this.year = year;
            this.month = month;
        }
    }
    class card
    {
        string? number;
        string? name;
        string? surname1;
        string? surname2;
        int cvv;
        dateForCard cardDate;


        public string? Number { get { return number; } set { this.number = value; } }
        public string? Name { get { return name; } set { this.name = value; } }
        public string? Surname1 { get { return surname1; } set { this.surname1 = value; } }
        public string? Surname2 { get { return surname2; } set { this.surname2 = value; } }
        public int Cvv { get {return cvv; } set { this.cvv = value; } }
        public dateForCard CardDate { get { return cardDate; } set { this.cardDate = value; } }

        public card(string? number, string? name, string? surname1, string? surname2, int cvv, dateForCard cardDate)
        {
            this.number = number;
            this.name = name;
            this.surname1 = surname1;
            this.surname2 = surname2;
            this.cvv = cvv;
            this.cardDate = cardDate;
        }
        
        public override string ToString()
        {
            string a = cardDate.Month < 10 ? "0" : "";
            return $"   {number}\n   {name} {surname1}    {a}{cardDate}";
        }
    }
    
    static void Main(string[] args)
    {
        card card1 = new card("1234 5678 9123 4567", "Howl", "Howlichenko", "Howlikov", 123, new dateForCard(2027, 9));

        Console.WriteLine(card1);

    }
}
