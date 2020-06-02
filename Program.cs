using Learning.DesignPatterns.Domain.Models;
using System;

namespace Learning.DesignPatterns.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Name = "Benjamin Friske";
            System.Console.WriteLine("Hello World!" + customer.Name);
        }
    }
}
