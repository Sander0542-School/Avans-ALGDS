using Alg1.Practica.Utils;
using System;

namespace Alg1.Practica.Practicum5
{
    public class ArrayStack : IStack
    {
        protected string[] values;
        protected int size;
        
        private int _used;

        public ArrayStack(int capacity)
        {
            if (capacity <= 0) throw new ArgumentOutOfRangeException();

            values = new string[capacity];
            size = capacity;
            _used = 0;
        }

        public void Push(string value)
        {
            if (IsFull())
                throw new InvalidOperationException();
            values[_used++] = value;
        }

        public string Pop()
        {
            if (IsEmpty()) return null;

            var result = values[--_used];
            values[_used] = null;

            return result;
        }

        public string Peek() => IsEmpty() ? null : values[_used - 1];

        public bool IsEmpty() => _used == 0;

        public bool IsFull() => _used == size;
    }
}