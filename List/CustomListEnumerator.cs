using System;
using System.Collections;

namespace List
{
    public class CustomListEnumerator<T> : IEnumerator
    {
        private Node<T> head;
        private Node<T> currentNode;

        public CustomListEnumerator(Node<T> node)
        {
            head = node;
            currentNode = null;
        }

        public object Current => head.Element;

        public bool MoveNext()
        {
            if (currentNode == null)
            {
                currentNode = head;
                return true;
            }else if (head.NextElement != null && head.Element != null)
            {
                head = head.NextElement;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            head = null;
        }
    }
}
