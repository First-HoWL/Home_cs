using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Game
{
    enum size
    {
        Small,
        Medium,
        Large
    }
    class Pizza
    {
        string? name;
        size pizzaSize;
        double price;

        public double Price { get { return price; } }
        public string? Name { get { return name; } }
        public size PizzaSize { get { return pizzaSize; } }
        public Pizza(string? name, size pizza_size, double price)
        {
            this.name = name;
            this.price = price;
            this.pizzaSize = pizza_size;
        }
        public override string ToString()
        {
            return $"{this.name} - {this.pizzaSize}, {this.price}grn";
        }
    }
    class Customer
    {
        string? name;
        string? phoneNumber;
        string? address;
        public string? Name { get { return name; } }
        public string? PhoneNumber { get { return phoneNumber; } }
        public string? Address { get { return address; } }

        public Customer(string? name, string? phoneNumber, string? address)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.address = address;
        }

        public override string ToString()
        {
            return $"{this.name} - {this.phoneNumber}, {this.address}";
        }

    }
    class Order
    {
        Customer customer;
        List<Pizza> pizzas;
        double totalPrice;


        public Order(Customer customer)
        {
            this.customer = customer;
            this.pizzas = new List<Pizza>();
        }

        public void addPizza(Pizza pizza)
        {
            this.pizzas.Add(pizza);
            CalculateTotalPrice();
        }
        public void CalculateTotalPrice()
        {
            double sum = 0;
            for (int i = 0; i < pizzas.Count; i++)
            {
                sum += pizzas[i].Price;
            }
            this.totalPrice = sum;
        }
        public override string ToString()
        {
            return $"Order: \n {customer}\n Pizzas: \n  {String.Join("\n  ", this.pizzas)}, \n {totalPrice}grn";
        }
    }


}
