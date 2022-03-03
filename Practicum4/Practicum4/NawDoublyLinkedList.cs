using System;
using Alg1.Practica.Utils;
using Alg1.Practica.Utils.Models;

namespace Alg1.Practica.Practicum4
{
    public class NawDoublyLinkedList
    {
        public DoubleLink First { get; set; }
        public DoubleLink Last { get; set; }

        public void InsertHead(NAW naw)
        {
            var newItem = new DoubleLink
            {
                Next = First,
                Naw = naw
            };

            if (First != null)
            {
                First.Previous = newItem;
            }

            First = newItem;
            if (Last == null)
            {
                Last = First;
            }
        }

        public NAW ItemAtIndex(int index)
        {
            int i = 0;
            var link = First;

            do
            {
                if (i++ == index)
                {
                    return link.Naw;
                }

                link = link.Next;
            } while (link.Next != null);

            return null;
        }

        public DoubleLink SwapLinkWithNext(DoubleLink linkI)
        {
            var linkJ = linkI.Next;

            if (linkJ == null) return null;

            var linkH = linkI.Previous;
            var linkK = linkJ.Next;

            if (First == linkI)
            {
                First = linkJ;
            }

            if (linkH != null)
            {
                linkH.Next = linkJ;
            }

            linkJ.Previous = linkH;
            linkJ.Next = linkI;
            linkI.Previous = linkJ;
            linkI.Next = linkK;

            if (linkK != null)
            {
                linkK.Previous = linkI;
            }

            if (Last == linkJ)
            {
                Last = linkI;
            }

            return linkJ;
        }

        public void BubbleSort()
        {
            if (First?.Next == null) return;

            var tmpLast = Last;

            do
            {
                bool itemMoved = false;

                var tmpFirst = First;

                while (tmpFirst.Next != null && tmpFirst != tmpLast)
                {
                    if (tmpFirst.Naw.CompareTo(tmpFirst.Next.Naw) == 1)
                    {
                        SwapLinkWithNext(tmpFirst);
                        tmpFirst = tmpFirst.Previous;
                        itemMoved = true;
                    }

                    tmpFirst = tmpFirst.Next;
                }

                if (!itemMoved) break;
            } while (tmpLast.Previous != null);
        }

        public BigO OrderOfBubbleSort()
        {
            return BigO.N2;
        }
    }
}