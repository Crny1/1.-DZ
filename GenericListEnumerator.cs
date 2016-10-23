using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DZ_2.zad
{
    public class GenericListEnumerator<T> :IEnumerator<T>
    {
        private GenericList<T> _collection;
        private int curIndex;
        private T curT;

        public GenericListEnumerator(GenericList<T> collection)
        {
            _collection = collection;
            curIndex = -1;
            curT = default(T);
        }

        public T Current
        {
            get
            {
                return curT;
            }
        }

       public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            if (++curIndex >= _collection.Count)  
            {
                return false;
            }
            else
            {
                curT = _collection.GetElement(curIndex);
            }
            return true;
        }

        public void Reset()
        {
            curIndex = -1;
        }
    }
}
