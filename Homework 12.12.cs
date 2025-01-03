using System.Text;
using System.Threading;
using System;
using System.IO;
using System.Net.NetworkInformation;



class Program
{

    class student {
        string? name;
        int yearOfBirth;
        string? group;
        double avg;

        public student(string? name, int yearOfBirth, string? group, double avg)
        {
            this.name = name;
            this.yearOfBirth = yearOfBirth;
            this.group = group;
            this.avg = avg;
        }

        public void print()
        {
            Console.WriteLine($"\t\b\b< {name} >");
            Console.WriteLine($"year of birth: {yearOfBirth}");
            Console.WriteLine($"group: {group}");
            Console.WriteLine($"avg: {avg}");
        }
        public int getAge()
        {
            return DateTime.Now.Year - yearOfBirth;
        }

    }

    static void Main(string[] args)
    {
       
        student Student = new student("HoWL", 2002, "a12", 10.3);

        Student.print();
        Console.WriteLine($"{Student.getAge()} years old");


    }
}
