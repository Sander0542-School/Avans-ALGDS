using System;
using System.Collections.Generic;
using Alg1.Practica.Utils;
using Alg1.Practica.Utils.Exceptions;
using Alg1.Practica.Utils.Models;


namespace Alg1.Practica.Practicum1
{
    public class NawArrayOrdered : INawArray, INawArrayOrdered
    {
        protected Alg1NawArray _nawArray;

        public Alg1NawArray Array => _nawArray;

        protected int _size;
        protected int _used = 0;

        public NawArrayOrdered(int initialSize)
        {
            if (initialSize <= 0 || initialSize > 1000000)
                throw new NawArrayOrderedInvalidSizeException();

            _size = initialSize;
            _nawArray = new Alg1NawArray(_size);
        }

        public void Show()
        {
            // Niet gevraagd

            System.Console.WriteLine("Array contains {0} of {1} items.", _used, _size);
            for (int i = 0; i < _size; i++)
            {
                if (i == _used)
                {
                    System.Console.WriteLine("------------------------------------------------------");
                }

                System.Console.Write("Item {0} contains: ", i);
                if (_nawArray[i] != null)
                {
                    _nawArray[i].Show();
                }
                else
                {
                    System.Console.WriteLine("nothing");
                }
            }
        }

        public int Count
        {
            get { return ItemCount(); }
            set { _used = value; }
        }

        public int ItemCount()
        {
            return _used;
        }

        public virtual void Add(NAW item)
        {
            if (_used >= _size)
                throw new NawArrayOrderedOutOfBoundsException();

            int i = _used;
            while (i > 0 && item.CompareTo(_nawArray[i - 1]) < 0)
                _nawArray[i] = _nawArray[--i];

            _nawArray[i] = item;
            _used++;
        }

        public void RemoveAtIndex(int index)
        {
            if (index < 0 || index >= _used)
                throw new NawArrayUnorderedOutOfBoundsException();

            int i = index;
            while (i < _used)
            {
                _nawArray[i] = _nawArray[++i];
            }

            _nawArray[i] = null;

            _used--;
        }

        public virtual bool Remove(NAW item)
        {
            try
            {
                int index = Find(item);

                RemoveAtIndex(index);

                return true;
            }
            catch (NawArrayOrderedOutOfBoundsException ignored)
            {
            }

            return false;
        }

        public NAW ItemAtIndex(int index)
        {
            if (index < 0 || index >= _used)
                throw new NawArrayOrderedOutOfBoundsException();

            return _nawArray[index];
        }


        public int Find(NAW item)
        {
            int min = 0;
            int max = _used - 1;

            while (true)
            {
                int center = (min + max) / 2;

                switch (item.CompareTo(_nawArray[center]))
                {
                    case -1:
                        max = center;
                        break;
                    case 0:
                        return center;
                    case 1:
                        min = center;
                        break;
                }

                if (min == max)
                {
                    break;
                }
            }

            return -1;
        }

        public bool Update(NAW oldValue, NAW newValue)
        {
            try
            {
                int index = Find(oldValue);

                RemoveAtIndex(index);

                Add(newValue);

                return true;
            }
            catch (NawArrayOrderedOutOfBoundsException ignored)
            {
            }

            return false;
        }
    }
}