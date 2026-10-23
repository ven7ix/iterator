namespace iterator
{
    internal class ArrayIterator<T>(List<T> ints) : IIterator<T>
    {
        readonly List<T> ints = ints;
        int cursor = -1;

        public T GetCurrent()
        {
            return ints[cursor];
        }

        public bool IsDone()
        {
            return cursor >= ints.Count;
        }

        public void Next()
        {
            cursor++;
        }

        public void Reset()
        {
            cursor = -1;
        }
    }
}
