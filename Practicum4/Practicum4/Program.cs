using System;
using Alg1.Practica.Utils.Models;

namespace Alg1.Practica.Practicum4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            UndoableNawArray undoableNawArray = new UndoableNawArray(10);
            
            // undoableNawArray.Add(new NAW("Persoon 1", "Adres 1", "Woonplaats 1"));
            // undoableNawArray.Add(new NAW("Persoon 2", "Adres 6", "Woonplaats 2"));
            // undoableNawArray.Add(new NAW("Persona non grata", "Adres 8", "Woonplaats 3"));
            // undoableNawArray.Add(new NAW("Persona 8", "Adres 3", "Woonplaats 3"));
            // undoableNawArray.Add(new NAW("Persoon 2", "Adres 8", "Woonplaats 2"));
            // undoableNawArray.Add(new NAW("Persona non grata", "Adres 3", "Woonplaats 3"));
            // undoableNawArray.Add(new NAW("Persoon 2", "Adres 2", "Woonplaats 2"));
            // undoableNawArray.Add(new NAW("Persoon 10", "Adres 10", "Woonplaats 2"));
            // undoableNawArray.Add(new NAW("Persoon 4", "Adres 4", "Woonplaats 2"));
            // undoableNawArray.Add(new NAW("Persoon 9", "Adres 9", "Woonplaats 1"));
            // undoableNawArray.Add(new NAW("Persoon 1", "Adres 5", "Woonplaats 1"));
            // undoableNawArray.Add(new NAW("Persona non grata", "Adres 7", "Woonplaats 3"));
            
            undoableNawArray.Show();
            
            Console.ReadKey();
        }
    }
}
