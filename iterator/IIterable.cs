namespace iterator
{
    internal interface IIterable<T>
    {
        IIterator<T> GetIterator();
    }
}
