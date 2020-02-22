using System;
using System.Collections;

namespace List
{
    public class CustomList : IEnumerable, ICustomLink
    {
        public Node Head { get; private set; }
        public Node Tail { get; private set; }

        public Notebook this[int index]
        {
            get
            {
                Node current = Head;

                int i = 0;
                while(current != null && i != index)
                {
                    current = current.NextElement;
                    i++;
                }
                return current.Element;
            }
        }

        public void Add(Notebook value)
        {
            Node newNode = new Node(value, null);
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

        public void Delete(Notebook value)
        {
            Node previous = null;
            Node current = Head;

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
            return new CustomListEnumerator(Head);
        }
    }
}
