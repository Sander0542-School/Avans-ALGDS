using System;
using Alg1.Practica.Utils.Models;

namespace Alg1.Practica.Practicum7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var dictionary = new NawDictionary(20);
            
            Console.WriteLine(dictionary.Count);
            
            dictionary.Insert("5chk2j5h2kjq", new NAW("Persoon 1", "Adres 1", "Woonplaats 1"));
            dictionary.Insert("ygfjhgfvhkjggjh",new NAW("Persoon 2", "Adres 6", "Woonplaats 2"));
            dictionary.Insert("4gctkulg4th",new NAW("Persona non grata", "Adres 8", "Woonplaats 3"));
            dictionary.Insert("g4t3crhiuoc43g52hi",new NAW("Persona 8", "Adres 3", "Woonplaats 3"));
            dictionary.Insert("c43gtuig42t",new NAW("Persoon 2", "Adres 8", "Woonplaats 2"));
            
            Console.WriteLine(dictionary.Count);
            Console.WriteLine(dictionary.LoadFactor);
            
            dictionary.Delete("ygfjhgfvhkjggjh");
            dictionary.Delete("g4t3crhiuoc43g52hi");
            
            Console.WriteLine(dictionary.Count);
            Console.WriteLine(dictionary.LoadFactor);
        }
    }
}
