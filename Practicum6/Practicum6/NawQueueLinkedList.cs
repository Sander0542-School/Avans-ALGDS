using System;
using Alg1.Practica.Utils.Models;

namespace Alg1.Practica.Practicum6
{
    public class NawQueueLinkedList
    {
        public Link First { get; set; }

        protected Link Last { get; set; }

        protected int _count;

        public void Enqueue(NAW naw)
        {
            var tmp = new Link {Naw = naw};

            if (_count++ == 0)
            {
                First = Last = tmp;
            }
            else
            {
                Last.Next = Last = tmp;
            }
        }

        public NAW Dequeue()
        {
            if (_count <= 0) return null;

            var tmp = First.Naw;
            First = First.Next;
            if (First == null) Last = null;
            _count--;

            return tmp;
        }

        public int Count() => _count;
    }
}