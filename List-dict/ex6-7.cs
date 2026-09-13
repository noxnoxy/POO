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
            var countries = new Dictionary<string, string>()
            {
                {"BE", "Belgium"},
                {"FR", "France"},
                {"DE", "Germany"}
            };

            foreach (KeyValuePair<string, string> kvp in countries)
             {
                    Console.WriteLine($"Clé: {kvp.Key} Valeur:{kvp.Value}");
             }

            Console.WriteLine("Entrez le code Pays:");
            string code = Console.ReadLine();

            if (countries.TryGetValue(code, out var countries2))
            {
                Console.WriteLine($"La clé {code} et sa valeur est {countries2}");
            }
            else
            {
                Console.WriteLine($"Le clé {code} n'existe pas.");
            }

        }
    }
}
