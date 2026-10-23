namespace iterator
{
    public interface IIterator<T>
    {
        void Reset();
        bool IsDone();
        void Next();
        T GetCurrent();
        void RemoveAt(int index);
    }
}
