using System;
using System.Collections.Generic;
using System.Linq;
using Alg1.Practica.Utils.Models;

namespace Alg1.Practica.Practicum6
{
    public class NawPriorityQueue
    {
        private readonly SortedDictionary<int, NawQueueLinkedList> _dictionary = new SortedDictionary<int, NawQueueLinkedList>();

        public void Enqueue(int priority, NAW naw)
        {
            if (!_dictionary.ContainsKey(priority)) _dictionary.Add(priority, new NawQueueLinkedList());

            _dictionary[priority].Enqueue(naw);
        }

        public NAW Dequeue()
        {
            if (_dictionary.Count == 0) return null;

            NAW tmp = _dictionary.First().Value.Dequeue();

            if (_dictionary.First().Value.Count() == 0) _dictionary.Remove(_dictionary.First().Key);

            return tmp;
        }

        public int Count() => _dictionary.Values.Sum(queue => queue.Count());

        public void Show() => Console.WriteLine("Hoi debugger");
    }
}