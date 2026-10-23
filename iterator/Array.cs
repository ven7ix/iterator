namespace iterator
{
    internal class Array<T>(List<T> ints) : IIterable<T>
    {
        readonly List<T> ints = ints;

        public IIterator<T> GetIterator()
        {
            return new ArrayIterator<T>(ints);
        }
    }
}
