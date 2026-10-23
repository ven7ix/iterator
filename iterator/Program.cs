namespace iterator
{
    internal class Program
    {
        static void Main()
        {
            var array = new Array<int>([6, 7, 5, 2, 4, 0]);
            IIterator<int> array_it = array.GetIterator();

            for (array_it.Reset(), array_it.Next(); !array_it.IsDone(); array_it.Next())
            {
                Console.WriteLine(array_it.GetCurrent());
            }
        }
    }
}
