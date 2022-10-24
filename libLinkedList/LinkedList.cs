using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace libLinkedList
{

    internal class Node<T>
    {
        // Properties
        public T mvalue { get; set; }
        public Node<T> mnext { get; set; }

        // Konstruktor
        public Node(T value, Node<T> next)
        {
            this.mvalue = value;
            this.mnext = next;
        }
    }
    public class SinglyLinkedList<T> : ILinkedList<T>, IEnumerable, IEnumerator<T>
    {
        // Membervariablen
        private Node<T> mhead;
        private Node<T> mlast;

        private int index = -1;

        // Properties
        public int length { get; set; }

        object IEnumerator.Current
        {
            get { return FindByIndex(index); }
        }

        public T Current
        {
            get { return default; }
        }


        // Konstruktor
        public SinglyLinkedList()
        {
            this.mhead = null;
            this.length = 0;
        }



        public void Add(T value)
        {
            Node<T> newNode = new Node<T>(value, null);
            if (this.mhead == null)
            {
                this.mhead = newNode;
                this.mlast = newNode;
            }
            else
            {
                this.mlast.mnext = newNode;
                this.mlast = newNode;
            }
            length++;
        }

        public bool Contains(T value)
        {
            for (Node<T> tmp = this.mhead; tmp != null; tmp = tmp.mnext)
            {
                if (tmp.mvalue.Equals(value))
                    return true;
            }
            return false;
        }

        public int Count()
        {
            return length;
        }

        public T FindByIndex(int index)
        {
            int idx = 0;
            for (Node<T> tmp = this.mhead; tmp != null; tmp = tmp.mnext)
            {
                idx++;
                if (idx == index)
                {
                    return tmp.mvalue;
                }

            }
            return default;
        }

        public bool IsObjectAtIndex(T value, int index)
        {
            int idx = 0;
            for (Node<T> tmp = this.mhead; tmp != null; tmp = tmp.mnext)
            {
                idx++;
                if (idx == index)
                {
                    if (tmp.mvalue.Equals(value))
                    {
                        return true;
                    }
                }
            }
            return false;
        }




        public bool Remove(T value)
        {
            Node<T> current = this.mhead;
            Node<T> prev = null;

            while (current != null)
            {
                if (current.mvalue.Equals(value))
                {
                    current = current.mnext;
                    if (prev != null)
                    {
                        prev.mnext = current;
                    }
                    length--;
                    return true;

                }
                prev = current;
                current = current.mnext;
            }

            return false;
        }

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }

        public bool MoveNext()
        {
            index++;
            return index <= length;
        }

        public void Reset()
        {
            index = -1;
        }

        public void Dispose()
        {
            index = -1;
        }
    }
}
