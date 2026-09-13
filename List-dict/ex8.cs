using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var product = new Dictionary<string, double>
            {
                {"Banane", 1.50 },
                {"Pomme", 2.99 },
                {"Orange", 0.99}

            };

            Console.WriteLine("Entrez le nom d'un fruit");
            string fruit = Console.ReadLine();

            if (product.TryGetValue(fruit, out var price))
            {
                Console.WriteLine($"Le fruit {fruit} coute {price}euro");
            }
            else
            {
                Console.WriteLine("Ce fruit n'est pas dans le dictionnaire");
            }
        }
    }
}