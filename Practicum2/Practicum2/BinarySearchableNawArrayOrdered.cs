using System;
using System.Collections.Generic;
using Alg1.Practica.Utils;
using Alg1.Practica.Utils.Exceptions;
using Alg1.Practica.Utils.Models;
using Alg1.Practica.Practicum1;


namespace Alg1.Practica.Practicum2
{
    public class BinarySearchableNawArrayOrdered : NawArrayOrdered, IBinarySearch
    {
        public BinarySearchableNawArrayOrdered(int initialSize) : base(initialSize)
        {
        }

        public int FindBinary(NAW item)
        {
            if (_used < 1) return -1;

            if (_used == 1) return _nawArray[0].CompareTo(item) == 0 ? 0 : -1;

            int min = 0;
            int max = _used - 1;

            while (min <= max)
            {
                int center = (min + max) / 2;
                int compared = item.CompareTo(_nawArray[center]);

                if (compared == 0) return center;
                if (compared > 0)
                {
                    min = center + 1;
                }
                else
                {
                    max = center - 1;
                }
            }

            return -1;
        }

        public void AddBinary(NAW item)
        {
            if (_used >= _size)
                throw new NawArrayOrderedOutOfBoundsException();

            int min = 0;
            int max = _used - 1;

            int position = 0;

            while (min <= max)
            {
                int center = (min + max) / 2;
                int compared = _nawArray[center].CompareTo(item);

                if (compared == 0)
                {
                    position = center;
                    break;
                }

                if (compared < 0)
                {
                    min = center + 1;
                }
                else
                {
                    max = center - 1;
                }
            }

            if (position == 0)
            {
                position = min;
            }

            for (int i = _used; i > position; i--)
            {
                _nawArray[i] = _nawArray[i - 1];
            }

            _nawArray[position] = item;
            _used++;
        }
    }
}