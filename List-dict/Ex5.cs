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
            List<string> names = new List<string>();
            Console.WriteLine("Entrez un nom");
            for(int i = 0; i <5; i++)
            {
                Console.WriteLine($"Prénoms {i + 1}:");
                string firstname = Console.ReadLine();
                names.Add(firstname);

            }
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Entrez un nom à chercher:");
            string searchName = Console.ReadLine();
            int position = names.IndexOf(searchName);

            if (position == -1)
            {
                Console.WriteLine("Prénom introuvable");
            }
            else
            {
                Console.WriteLine($"Le prénom se situe à la {position + 1} place.");
            }

        }
    }
}
