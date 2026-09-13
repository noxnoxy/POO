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

            List<(string name, double price)> panier = new List<(string,double)>();
            double total = 0;

            Console.WriteLine("Bienvenue dans votre magasin");
            Console.WriteLine("Taper 'stop' pour terminer vos achats");

            while (true)
            {
                Console.WriteLine("Entrez le nom d'un produit");
                string fruit = Console.ReadLine();

                if (fruit.Equals("stop", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                if (product.TryGetValue(fruit, out double price))
                {
                    panier.Add((fruit, price));
                    Console.WriteLine($"{fruit} ajouté au panier!");
                }
                else
                {
                    Console.WriteLine("Le produit n'existe pas");
                }

                if (panier.Count == 0)
                {
                    Console.WriteLine("Votre panier est vide.");
                }
                else
                {
                    foreach (var article in panier)
                    {
                        Console.WriteLine($"{article.name}: {article.price}");
                        total += article.price;
                    }
                }
                Console.WriteLine($"Total à payer: {total}");
            }
        }
    }
}