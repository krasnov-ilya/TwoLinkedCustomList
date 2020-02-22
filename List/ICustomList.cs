namespace List
{
    public interface ICustomList<T>
    {
        void Add(T value);
        T this [int index] { get; }
        void Delete(T value);
    }
}
