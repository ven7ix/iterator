namespace iterator
{
    internal interface IIterator<T>
    {
        void Reset();
        bool IsDone();
        void Next();
        T GetCurrent();
    }
}
