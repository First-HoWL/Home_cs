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
        Pizza pizza1 = new Pizza("Peperoni", size.Small, 149);
        bool isBreak;
        Console.WriteLine("Your name");
        string name = Console.ReadLine();
        Console.WriteLine("Your Phone Number");
        string Phone = Console.ReadLine();
        Console.WriteLine("Your address");
        string address = Console.ReadLine();

        Order order = new Order(new Customer(name, Phone, address));
        do
        {
            Console.WriteLine("What pizza do you want to choose: ");
            Console.WriteLine(" Peperoni - 149/179/209\n Margarita - 79/109/139\n 4chesse - 119/149/179\n Marinara - 129/159/189");
            Console.Write("> ");
            int choose1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Small, Medium or Large?");
            Console.Write("> ");
            int choose2 = Convert.ToInt32(Console.ReadLine());
            if (choose1 == 1)
            {
                if (choose2 == 1)
                {
                    pizza1 = new Pizza("Peperoni", size.Small, 149);
                }
                else if (choose2 == 2)
                {
                    pizza1 = new Pizza("Peperoni", size.Medium, 179);
                }
                else if (choose2 == 3)
                {
                    pizza1 = new Pizza("Peperoni", size.Large, 209);
                }
            }
            else if (choose1 == 2)
            {
                if (choose2 == 1)
                {
                    pizza1 = new Pizza("Margarita", size.Small, 79);
                }
                else if (choose2 == 2)
                {
                    pizza1 = new Pizza("Margarita", size.Medium, 109);
                }
                else if (choose2 == 3)
                {
                    pizza1 = new Pizza("Margarita", size.Large, 139);
                }
            }
            else if (choose1 == 3)
            {
                if (choose2 == 1)
                {
                    pizza1 = new Pizza("4chesse", size.Small, 119);
                }
                else if (choose2 == 2)
                {
                    pizza1 = new Pizza("4chesse", size.Medium, 149);
                }
                else if (choose2 == 3)
                {
                    pizza1 = new Pizza("4chesse", size.Large, 179);
                }
            }
            else if (choose1 == 4)
            {
                if (choose2 == 1)
                {
                    pizza1 = new Pizza("Marinara", size.Small, 129);
                }
                else if (choose2 == 2)
                {
                    pizza1 = new Pizza("Marinara", size.Medium, 159);
                }
                else if (choose2 == 3)
                {
                    pizza1 = new Pizza("Marinara", size.Large, 189);
                }
            }
            order.addPizza(pizza1);



            Console.WriteLine("do you want to add another pizzas? 1. yes, 2. no");
            int choose3 = Convert.ToInt32(Console.ReadLine());

            if (choose3 == 1)
                isBreak = true;
            else
                isBreak = false;
        } while (isBreak);
        Console.WriteLine(order.ToString());

    }

}
