using System;
using Alg1.Practica.Practicum2;

namespace Alg1.Practica.Practicum3
{
    public class AlternativeBubbleSortableNawArrayUnordered : BubbleSortableNawArrayUnordered
    {
        public AlternativeBubbleSortableNawArrayUnordered(int size) : base(size)
        {
        }

        public void BubbleSortAlternative()
        {
            for (int outer = _used - 1; outer > 0; outer--)
            {
                for (int inner = 0; inner < outer; inner++)
                {
                    if (_nawArray[inner].CompareTo(_nawArray[inner + 1]) == 1)
                    {
                        _nawArray.Swap(inner, inner + 1);
                    }
                }
            }
        }
    }
}