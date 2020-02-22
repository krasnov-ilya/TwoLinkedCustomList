namespace List
{
    public class TwoLinkedNode<T> : Node<T>
    {
        public TwoLinkedNode<T> PreviousElement { get; set; }
        public TwoLinkedNode(T element, TwoLinkedNode<T> nextElement, TwoLinkedNode<T> previousElement) : base(element, nextElement)
        {
            PreviousElement = previousElement;
        }
    }
}