using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prva_DZ 
{
    class IntegerList : IIntegerList
    {
        private int[] _internalStorage;
        private int sizeofArray;
        private int numberOfElements=0;
        private int[] _backupStorage;

        public IntegerList (int sizeofArray)
        {
            this.sizeofArray = sizeofArray;
            if(sizeofArray<1)
            {
                throw new ArgumentException("Number must be greater then 0");
            }
            _internalStorage = new int [sizeofArray];
        }
        public void Add(int x)
        {
            if(sizeofArray==numberOfElements)
            {
                _backupStorage = new int[numberOfElements];
                for (int i = 0; i < numberOfElements; i++)
                {
                    _backupStorage[i] = _internalStorage[i];
                }
                _internalStorage = new int[2 * sizeofArray];
                for (int i = 0; i < numberOfElements; i++)
                {
                    _internalStorage[i] = _backupStorage[i];
                }
                sizeofArray = 2 * sizeofArray;
            }
            _internalStorage[numberOfElements] = x;
            numberOfElements++;
        }
        public bool Remove(int x)
        {
            for (int j = 0; j < _internalStorage.Length; j++)
            {
                if (_internalStorage[j] == x)
                {
                    return RemoveAt(j);
                }
            }
            return false;
        }
        public bool RemoveAt(int Index)
        {
            if (Index>_internalStorage.Length)
            {
                return false;
            }
            else
            {
                int i = _internalStorage.Length-Index;

                while (i>=0)
                {
                    _internalStorage[Index] = _internalStorage[Index + 1];
                    i--;
                }
                return true;
            }
            
        }
        public int GetElement(int x)
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
        public int IndexOf(int x)
        {
            for (int i = 0; i < _internalStorage.Length; i++)
            {
                if (_internalStorage[i]==x)
                {
                    return i+1;
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
            foreach (int item in _internalStorage)
            {
                _internalStorage[item] = 0;
            }
        }
        public bool Contains(int item)
        {
            int j = _internalStorage.Length;
            for (int i = 0; j < 5; i++)
            {
                if (_internalStorage[i]==item)
                {
                    return true;
                }
            }
            return false;
        }
        
    }
}
