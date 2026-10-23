namespace iterator
{
    public class Array<T>(List<T> ints) : IIterable<T>
    {
        readonly List<T> ints = ints;

        public IIterator<T> GetIterator()
        {
            return new ArrayIterator(this);
        }

        private class ArrayIterator(Array<T> owner) : IIterator<T>
        {
            readonly Array<T> owner = owner;
            int cursor = -1;

            public T GetCurrent()
            {
                return owner.ints[cursor];
            }

            public bool IsDone()
            {
                return cursor >= owner.ints.Count;
            }

            public void Next()
            {
                cursor++;
            }

            public void RemoveAt(int index)
            {
                owner.ints.RemoveAt(index);

                if (cursor >= index)
                {
                    cursor--;
                }
            }

            public void Reset()
            {
                cursor = -1;
            }
        }
    }
}
