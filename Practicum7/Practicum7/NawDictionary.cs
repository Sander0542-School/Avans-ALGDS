using System;
using Alg1.Practica.Utils;
using Alg1.Practica.Utils.Models;

namespace Alg1.Practica.Practicum7
{
    public class NawDictionary : INawDictionary
    {
        public int Size { get; }
        protected LogFile[] logFiles;
        private int _count;

        public NawDictionary(int size)
        {
            Size = size;
            logFiles = new LogFile[size];
            _count = 0;
            for (int i = 0; i < logFiles.Length; ++i)
                logFiles[i] = new LogFile();
        }

        protected int KeyToIndex(string key)
        {
            if (key == null)
            {
                throw new ArgumentNullException();
            }

            return Math.Abs(key.GetHashCode() % Size);
        }


        public void Insert(string key, NAW value)
        {
            logFiles[KeyToIndex(key)].Insert(key, value);

            _count++;
        }

        public NAW Find(string key)
        {
            if (key == null)
            {
                throw new ArgumentNullException();
            }

            return logFiles[KeyToIndex(key)].Find(key);
        }

        public NAW Delete(string key)
        {
            if (key == null)
            {
                throw new ArgumentNullException();
            }
            
            var result = logFiles[KeyToIndex(key)].Delete(key);

            if (result != null)
            {
                _count--;
            }

            return result;
        }


        public int Count => _count;

        public double LoadFactor => (double)Count / Size;
    }
}