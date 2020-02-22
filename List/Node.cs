namespace List
{
    public class Node<T>
    {
        public Node(T element, Node<T> nextElement = null)
        {
            Element = element;
            NextElement = nextElement;
        }
        public T Element { get; set; }
        public Node<T> NextElement { get; set; }
    }
}
