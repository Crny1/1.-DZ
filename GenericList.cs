using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DZ_2.zad
{
    public class GenericList<T> : IGenericList<T>
    {
        private T[] _internalStorage;
        private int sizeofArray;
        private int numberOfElements = 0;
        private T[] _backupStorage;

        public GenericList()
        {
            if (sizeofArray < 1)
            {
                throw new ArgumentException("Number must be greater then 0");
            }
            _internalStorage = new T[4];
            sizeofArray = 4;
        }
        public void Add(T x)
        {
            if (sizeofArray == numberOfElements)
            {
                _backupStorage = new T[numberOfElements];
                for (int i = 0; i < numberOfElements; i++)
                {
                    _backupStorage[i] = _internalStorage[i];
                }
                _internalStorage = new T[2 * sizeofArray];
                for (int i = 0; i < numberOfElements; i++)
                {
                    _internalStorage[i] = _backupStorage[i];
                }
                sizeofArray = 2 * sizeofArray;
             }
             _internalStorage[numberOfElements] = x;
             numberOfElements++;
        }
        public bool Remove(T x)
        {
            
            for (int j = 0; j < _internalStorage.Length; j++)
            {
                if (EqualityComparer<T>.Default.Equals(x, _internalStorage[j]))
                {
                    return RemoveAt(j);
                }
            }
            return false;
        }
        public bool RemoveAt(int Index)
        {
            if (Index > _internalStorage.Length)
            {
                return false;
            }
            else
            {
                int i = _internalStorage.Length - Index;

                while (i >= 0)
                {
                    _internalStorage[Index] = _internalStorage[Index + 1];
                    i--;
                }
                return true;
            }

        }
        public T GetElement(int x)
        {
            int j = _internalStorage.Length;
            if (j > x)
            {
                return _internalStorage[x - 1];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public int IndexOf(T x)
        {
            for (int i = 0; i < _internalStorage.Length; i++)
            {
                if (EqualityComparer<T>.Default.Equals(x, _internalStorage[i]))
                {
                    return i + 1;
                }
            }
            return -1;
        }
        public int Count
        {
            get
            {
                return numberOfElements;
            }
        }
        public void Clear()
        {
            for ( int i = 0; i < numberOfElements; i++)
            {
                _internalStorage[i] = default(T);
            }
            numberOfElements = 0;
        }
        public bool Contains(T item)
        {
            int j = _internalStorage.Length;
            for (int i = 0; j < 5; i++)
            {
                if (EqualityComparer<T>.Default.Equals(item, _internalStorage[j]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
