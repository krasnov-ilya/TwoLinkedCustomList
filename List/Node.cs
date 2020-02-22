namespace List
{
    public class Node
    {
        public Node(Notebook element, Node nextElement = null)
        {
            Element = element;
            NextElement = nextElement;
        }
        public Notebook Element { get; set; }
        public Node NextElement { get; set; }
    }
}
