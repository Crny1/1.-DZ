using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DZ_2.zad
{
    public interface IGenericList<T> 
    {
        void Add(T x);

        bool Remove(T item);

        bool RemoveAt(int index);

        T GetElement(int index);

        int IndexOf(T item);

        int Count { get; }

        void Clear();

        bool Contains(T item);
    }
}
