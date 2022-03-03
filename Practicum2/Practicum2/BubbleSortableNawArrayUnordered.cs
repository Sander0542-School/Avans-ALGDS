using Alg1.Practica.Practicum1;
using Alg1.Practica.Utils;

namespace Alg1.Practica.Practicum2
{
    public class BubbleSortableNawArrayUnordered : NawArrayUnordered, IBubbleSort
    {
        public BubbleSortableNawArrayUnordered(int initialSize) : base(initialSize)
        {
        }

        public void BubbleSort()
        {
            if (_used <= 1) return;

            int outerLoop = _used - 1;

            for (int i = outerLoop; i > 0; i--)
            {
                bool itemMoved = false;

                for (int j = 0; j < i; j++)
                {
                    if (_nawArray[j].CompareTo(_nawArray[j + 1]) == 1)
                    {
                        _nawArray.Swap(j, j + 1);
                        itemMoved = true;
                    }
                }

                if (!itemMoved) break;
            }
        }

        public void BubbleSortInverted()
        {
            if (_used < 2)
            {
                return;
            }

            int outerLoop = _used - 1;

            for (int j = outerLoop; j > 0; j--)
            {
                bool itemMoved = false;
                for (int i = outerLoop; i > 0; i--)
                {
                    if (_nawArray[i - 1].CompareTo(_nawArray[i]) == 1)
                    {
                        _nawArray.Swap(i - 1, i);
                        itemMoved = true;
                    }
                }

                if (!itemMoved)
                    break;
            }
        }
    }
}