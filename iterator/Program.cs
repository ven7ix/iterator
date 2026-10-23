namespace iterator
{
    public class Program
    {
        public static void Main()
        {
            var array = new Array<int>([6, 7, 5, 2, 4, 0]);
            IIterator<int> array_it = array.GetIterator();
            int i = 0;
            for (array_it.Reset(), array_it.Next(); !array_it.IsDone(); array_it.Next(), i++)
            {
                Console.WriteLine(array_it.GetCurrent());
                if (i == 3)
                {
                    array_it.RemoveAt(3);
                }
            }

            Console.WriteLine();

            for (array_it.Reset(), array_it.Next(); !array_it.IsDone(); array_it.Next())
            {
                Console.WriteLine(array_it.GetCurrent());
            }
        }
    }
}
