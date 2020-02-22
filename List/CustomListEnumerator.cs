using System;
using System.Collections;

namespace List
{
    public class CustomListEnumerator : IEnumerator
    {
        private Node head;
        private Node currentNode;

        public CustomListEnumerator(Node node)
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
