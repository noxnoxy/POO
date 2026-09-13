using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Exercices
{
    internal class SeachNameList
    {
        // créer une liste
        private List<string> names = new List<string>();
        // ajouter dans une liste
         names.Add("Paola");
         names.Add("Lola");
         names.Add("Michel");
         names.Add("Noa");
         names.Add("Matheo");

         foreach (string name in names)
         {
                // print
                Console.Write(name);
         }

        Console.WriteLine("Entrez un nom:");
        string searchName = Console.ReadLine();
        Console.WriteLine(names.Contains(searchName));
    }
}
