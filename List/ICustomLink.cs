namespace List
{
    public interface ICustomLink
    {
        void Add(Notebook value);
        Notebook this [int index] { get; }
        void Delete(Notebook value);
    }
}
