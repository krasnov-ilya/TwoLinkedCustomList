using System;
using System.Collections;

namespace List
{
    public class CustomList<T> : IEnumerable, ICustomList<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }

        public T this[int index]
        {
            get
            {
                Node<T> current = Head;

                int i = 0;
                while(current != null && i != index)
                {
                    current = current.NextElement;
                    i++;
                }
                return current.Element;
            }
        }

        public virtual void Add(T value)
        {
            Node<T> newNode = AssignmentNode(value);
            if (Head == null)
            {
                Head = newNode;
                Tail = Head;
            }
            else
            {
                Tail = Tail.NextElement = newNode;
            }
           
        }

        protected virtual void SetTail(Node<T> node)
        {
            Tail.NextElement = node;
        }

        protected virtual Node<T> AssignmentNode(T value)
        {
            return new Node<T>(value, null);
        }

        public virtual void Delete(T value)
        {
            Node<T> previous = null;
            Node<T> current = Head;

            while (current != null)
            {
                if (current.Element.Equals(value))
                {
                    if (previous != null)
                    {
                        previous.NextElement = current.NextElement;
                        if (current.NextElement == null)
                        {
                            Tail = previous;
                        }
                    }
                    else
                    {
                        Head = Head.NextElement;
                        if(Head == null)
                        {
                            Tail = null;
                        }
                    }
                }
                previous = current;
                current = current.NextElement;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return new CustomListEnumerator<T>(Head);
        }
    }
}
