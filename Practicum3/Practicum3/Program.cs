using System;
using Alg1.Practica.Utils.Models;

namespace Alg1.Practica.Practicum3
{
    class Program
    {
        public static void Main(string[] args)
        {

            AlternativeBubbleSortableNawArrayUnordered orderedArray = new AlternativeBubbleSortableNawArrayUnordered(11);

            // Testaanroepen Add:

            orderedArray.Add(new NAW("Persoon 1", "Adres 1", "Woonplaats 1"));
            orderedArray.Add(new NAW("Persoon 2", "Adres 6", "Woonplaats 2"));
            orderedArray.Add(new NAW("Persoon 10", "Adres 10", "Woonplaats 2"));
            orderedArray.Add(new NAW("Persona non grata", "Adres 3", "Woonplaats 3"));
            orderedArray.Add(new NAW("Persoon 2", "Adres 8", "Woonplaats 2"));
            orderedArray.Add(new NAW("Persoon 9", "Adres 9", "Woonplaats 1"));
            orderedArray.Add(new NAW("Persoon 7", "Adres 10", "Woonplaats 4"));
            orderedArray.Add(new NAW("Persoon 1", "Adres 5", "Woonplaats 1"));
            orderedArray.Add(new NAW("Persoon 2", "Adres 2", "Woonplaats 2"));
            orderedArray.Add(new NAW("Persoon 4", "Adres 4", "Woonplaats 2"));
            orderedArray.Add(new NAW("Persona non grata", "Adres 7", "Woonplaats 3"));
            
            orderedArray.BubbleSortAlternative();

            orderedArray.Show();
            
            // Console.ReadKey();
            
            // PerformanceTest.TestSortPerformance();
        }
    }
}
