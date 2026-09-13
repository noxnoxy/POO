using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                numbers.Add(rand.Next(1, 500));
            }

            //trier une liste 
            numbers.Sort();
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Entrez un nombre à supprimer");
            int ToRemove = int.Parse(Console.ReadLine());
            //supprimer élement d'une liste
            numbers.Remove(ToRemove);

            Console.WriteLine("Liste mise à jour:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            

        }
    }
}