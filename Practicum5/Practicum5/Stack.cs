using Alg1.Practica.Utils;
using Alg1.Practica.Utils.Models;

namespace Alg1.Practica.Practicum5
{
    public class Stack : IStack
    {
        protected StackLink First { get; set; }

        public void Push(string value)
        {
            var stackLink = new StackLink
            {
                Next = First,
                String = value
            };

            First = stackLink;
        }

        public string Pop()
        {
            var result = First?.String;

            First = First?.Next;

            return result;
        }

        public string Peek() => First?.String;

        public bool IsEmpty() => First == null;
    }
}