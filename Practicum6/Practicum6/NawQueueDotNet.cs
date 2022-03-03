using System;
using System.Collections.Generic;
using Alg1.Practica.Utils.Models;

namespace Alg1.Practica.Practicum6
{
    public class NawQueueDotNet
    {
        private Queue<NAW> _queue = new Queue<NAW>();

        public void Enqueue(NAW naw) => _queue.Enqueue(naw);

        public NAW Dequeue() => _queue.Count == 0 ? null : _queue.Dequeue();

        public int Count() => _queue.Count;
    }
}