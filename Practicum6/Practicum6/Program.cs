using System;
using Alg1.Practica.Practicum6;
using Alg1.Practica.Utils.Models;

namespace Practicum6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var queue = new NawPriorityQueue();
            
            // queue.Enqueue(0, new NAW("John Doe", "Example Road 1", "Example City"));
            queue.Enqueue(0, new NAW("John Doe", "Example Road 1", "Example Town"));
            queue.Enqueue(3, new NAW("Jane Doe", "Example Road 2", "Example Town"));
            queue.Enqueue(2, new NAW("Jane Doe", "Example Road 3", "Example City"));
            
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
        }
    }
}
