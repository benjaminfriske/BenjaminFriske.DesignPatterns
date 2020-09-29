using Learning.DesignPatterns.Domain.Models;

namespace Learning.DesignPatterns.Console
{
    /// <summary>
    /// Program to study design patterns.
    /// </summary>
    public class Program
    {
        private static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Name = "Benjamin Friske";
            System.Console.WriteLine("Hello World!" + customer.Name);
        }
    }
}
