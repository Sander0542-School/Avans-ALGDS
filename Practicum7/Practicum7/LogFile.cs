using System;
using Alg1.Practica.Utils;
using Alg1.Practica.Utils.Models;


namespace Alg1.Practica.Practicum7
{
    public class LogFile : INawDictionary
    {
        protected LogFileLink Head { get; set; }

        public virtual void Insert(string key, NAW value)
        {
            if (key == null)
            {
                throw new ArgumentNullException();
            }

            Head = new LogFileLink(key, value, Head);
        }

        public virtual NAW Find(string key)
        {
            if (key == null)
            {
                return null;
            }

            var current = Head;
            
            do
            {
                if (current.Key == key)
                {
                    return current.Value;
                }
                
                current = current.Next;
            } while (current != null);

            return null;
        }

        public virtual NAW Delete(string key)
        {
            if (key == null || Head == null)
            {
                return null;
            }

            var current = Head;
            LogFileLink previous = null;

            do
            {
                if (current.Key == key)
                {
                    var tmp = current.Value;

                    if (previous == null)
                    {
                        Head = current.Next;
                    }
                    else
                    {
                        previous.Next = current.Next;
                    }

                    return tmp;
                }
                
                previous = current;
                current = current.Next;
            } while (current != null);

            return null;
        }
    }
}