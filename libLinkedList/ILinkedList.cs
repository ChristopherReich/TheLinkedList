using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libLinkedList
{
    public interface ILinkedList<T> : IEnumerable
    {
        void Add(T value);
        bool Contains(T value);
        bool Remove(T value);
        bool IsObjectAtIndex(T value, int index);
        T FindByIndex(int index);
        int Count();
        int length { get; set; }
    }
}
